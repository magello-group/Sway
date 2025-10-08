using Sway.Dal.Dto;
using Sway.Dal.Enums;
using Sway.Dal.Interfaces;
using Sway.DalMock.MockDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sway.DalMock
{
	public class APIRequestDal : IAPIRequestDal
	{
		public APIRequestDto Fetch(int id)
		{
			var data = (from r in Database.APIKeys
						where r.Id == id
						select new APIRequestDto
						{
							Id = r.Id,
							Model = r.Model,
							APIKey = r.APIKey,
							Endpoint = r.Endpoint,
							MediaType = r.MediaType
						}).FirstOrDefault();

			return data
				?? throw new InvalidOperationException($"APIKey with id {id} not found.");
		}

		public APIRequestDto Fetch(string name)
		{
			var data = (from r in Database.APIKeys
						where r.Model.Equals(name)
						select new APIRequestDto
						{
							Id = r.Id,
							Model = r.Model,
							APIKey = r.APIKey,
							Endpoint = r.Endpoint,
							MediaType = r.MediaType
						}).FirstOrDefault();

			return data
				?? throw new InvalidOperationException($"APIKey with name '{name}' not found.");
		}

		public APIRequestDto Fetch(APIModels model)
		{
			var data = (from r in Database.APIKeys
						where r.Model.Equals(model)
						select new APIRequestDto
						{
							Id = r.Id,
							Model = r.Model,
							APIKey = r.APIKey,
							Endpoint = r.Endpoint,
							MediaType = r.MediaType
						}).FirstOrDefault();

			CheckAPIKeyValidity(data?.APIKey!);

			return data
				?? throw new InvalidOperationException($"APIKey with model '{model}' not found.");
		}

		private void CheckAPIKeyValidity(string apiKey)
		{
			if (string.IsNullOrWhiteSpace(apiKey))
				throw new InvalidOperationException("Missing OPPER_API_KEY environment variable.");
		}
	}
}

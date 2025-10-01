using Sway.Dal.Dto;
using Sway.Dal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sway.Dal.Interfaces
{
	public interface IAPIRequestDal
	{
		APIRequestDto Fetch(int id);
		APIRequestDto Fetch(string name);
		APIRequestDto Fetch(APIModels model);
	}
}

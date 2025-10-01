using Sway.Dal.Enums;

namespace Sway.DalMock.MockDb
{
	public class APIRequestModel
	{
		public int Id { get; set; }
		public APIModels Model { get; set; }
		public string APIKey { get; set; } = string.Empty;
		public string Endpoint { get; set; } = string.Empty;
		public string MediaType { get; set; } = "application/json";
	}
}

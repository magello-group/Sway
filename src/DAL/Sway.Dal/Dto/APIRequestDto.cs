using Sway.Dal.Enums;

namespace Sway.Dal.Dto
{
	public class APIRequestDto
	{
		public int Id { get; set; } = 0;
		public required APIModels Model { get; set; }
		public required string APIKey { get; set; }
		public string Endpoint { get; set; } = string.Empty;
		public string MediaType { get; set; } = string.Empty;
	}
}

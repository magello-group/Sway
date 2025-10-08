using Sway.Dal.Enums;

namespace Sway.DalMock.MockDb
{
	public class Database
	{
		public static List<APIRequestModel> APIKeys { get; private set; }

		static Database()
		{
			APIKeys = new List<APIRequestModel>
			{
				new APIRequestModel{ Id = 0, Model = APIModels.Opper, APIKey = Environment.GetEnvironmentVariable("OPPER_API_KEY") ?? string.Empty, Endpoint = "https://api.opper.ai/v2/call" },
				new APIRequestModel{ Id = 1, Model = APIModels.OpenAI, APIKey = "sadlofjewpfedhkgaldfv", Endpoint = "https://api.chatgpt.com/v2/request" },
				new APIRequestModel{ Id = 2, Model = APIModels.Gemini, APIKey = "ewroiyjbkldbqrrrö-4rkf", Endpoint = "https://api.gemini.ai/v2/getanswer" }
			};
		}
	}
}

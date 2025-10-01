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
				//new APIKeyData{ Id = 0, Model = APIModels.Opper, APIKey = "op-ESZCBUT1VRVO2F3TGTI8", Endpoint = "https://api.opper.ai/v2/call" },
				new APIRequestModel{ Id = 0, Model = APIModels.Opper, APIKey = "op-A2EGIMSYY4RJILF8IM0X", Endpoint = "https://api.opper.ai/v2/call" },
				new APIRequestModel{ Id = 1, Model = APIModels.OpenAI, APIKey = "sadlofjewpfedhkgaldfv", Endpoint = "https://api.chatgpt.com/v2/request" },
				new APIRequestModel{ Id = 2, Model = APIModels.Gemini, APIKey = "ewroiyjbkldbqrrrö-4rkf", Endpoint = "https://api.gemini.ai/v2/getanswer" }
			};
		}
	}
}

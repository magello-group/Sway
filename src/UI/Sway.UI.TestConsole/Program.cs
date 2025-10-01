using Sway.Core.Extensions;
using Sway.Dal.Enums;
using Sway.Library;
using System.Text;
using static System.Console;

namespace Sway.UI.TestConsole
{
	internal class Program
	{
		//[STAThread]
		static async Task Main(string[] args)
		{
			while (true)
			{
				try
				{
					ShowMenu();

					switch (ReadKey().KeyChar)
					{
						case '1': await OpperPostAsync(); break;
						case '2': OpperPost(); break;
						case '3': ListAssignments(); break;
						case '0': WriteLine(); return;

						default: ShowMenu(); break;
					}
				}
				catch (Exception ex)
				{
					WriteLine();
					WriteLine("There was an error: ");
					while (ex != null)
					{
						WriteLine(ex.Message);
						ex = ex.InnerException;
					}
				}

				WriteLine();
				WriteLine("Press <ENTER> to return to menu.");
				ReadLine();
			}
		}

		public static void ShowMenu()
		{
			Clear();
			WriteLine("PREREQ:");
			WriteLine("1. Set first req here,");
			WriteLine("2. Set second req here");
			WriteLine("");
			WriteLine("- Select which command to execute.");
			WriteLine("");
			WriteLine(" 1) Post to Opper Asynchronously.");
			WriteLine(" 2) Post to Opper Synchronously.");
			WriteLine(" 3) List assignments.");
			WriteLine(" 0) Exit");

			WriteLine("");
			Write(" > ");
		}

		private static async Task OpperPostAsync()
		{
			WriteLine("\nWhat would you like to ask?");
			var question = ReadLine();

			var apiData = APIRequestInfo.GetAPIData(APIModels.Opper);
			string jsonBody = $"{{\"name\": \"respond\", \"input\": \"{question}\"}}";


			using var client = new HttpClient
			{
				Timeout = TimeSpan.FromSeconds(30)
			};

			var request = new HttpRequestMessage(HttpMethod.Post, apiData.Endpoint)
			{
				Content = new StringContent(jsonBody, Encoding.UTF8, apiData.MediaType)
			};

			request.Headers.Add("Authorization", $"Bearer {apiData.APIKey}");

			WriteLine("Sending request...");
			Thread.Sleep(1000);
			WriteLine($"Using the {apiData.Model} model - {apiData.Model.GetDescription()}");

			HttpResponseMessage response = await client.SendAsync(request);

			string responseBody = await response.Content.ReadAsStringAsync();

			WriteLine($"Status Code: {(int)response.StatusCode}");
			WriteLine("Response: " + responseBody);
		}

		private static void OpperPost()
		{
			string apiKey = "op-ESZCBUT1VRVO2F3TGTI8";
			string jsonBody = "{\"name\": \"respond\", \"input\": \"Please suggest a way to build a biological computer?\"}";

			using var client = new HttpClient
			{
				Timeout = TimeSpan.FromSeconds(30)
			};

			var request = new HttpRequestMessage(HttpMethod.Post, "https://api.opper.ai/v2/call")
			{
				Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
			};
			request.Headers.Add("Authorization", $"Bearer {apiKey}");

			// Skicka begäran synkront
			HttpResponseMessage response = client.Send(request);

			string responseBody = response.Content.ReadAsStringAsync().Result;

			WriteLine($"Status Code: {(int)response.StatusCode}");
			WriteLine("Response: " + responseBody);
		}

		private static void ListAssignments()
		{
			throw new NotImplementedException();
		}
	}
}

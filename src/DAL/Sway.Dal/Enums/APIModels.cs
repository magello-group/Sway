using System.ComponentModel;

namespace Sway.Dal.Enums
{
	public enum APIModels
	{
		[Description("The Opper AI interface from the Swedish company Opper.")]
		Opper,
		[Description("The OpenAI GPT models.")]
		OpenAI,
		[Description("The Gemini AI from Google DeepMind.")]
		Gemini
	}
}

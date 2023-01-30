using Newtonsoft.Json;

namespace AuthenticationApp.Models
{
	public class ReCaptchaResponse
	{
		[JsonProperty("success")]
		public string? Success { get; set; }

		[JsonProperty("error-codes")]
		public List<string>? ErrorCodes { get; set; }
	}
}

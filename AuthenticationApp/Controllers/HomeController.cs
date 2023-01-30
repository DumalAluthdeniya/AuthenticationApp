using AuthenticationApp.Data;
using AuthenticationApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace AuthenticationApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {

            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
		{
            return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		//[HttpPost]
		//public ActionResult ValidateCaptcha()
		//{
		//	var response = Request["g-recaptcha-response"];
		//	//secret that was generated in key value pair
		//	const string secret = "YOUR KEY VALUE PAIR";

		//	var client = new WebClient();
		//	var reply =
		//		client.DownloadString(
		//			string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
		//		secret, response));

		//	var captchaResponse = JsonConvert.DeserializeObject<ReCaptchaResponse>(reply);

		//	//when response is false check for the error message
		//	if (!captchaResponse.Success)
		//	{
		//		if (captchaResponse.ErrorCodes.Count <= 0) return View();

		//		var error = captchaResponse.ErrorCodes[0].ToLower();
		//		switch (error)
		//		{
		//			case ("missing-input-secret"):
		//				ViewBag.Message = "The secret parameter is missing.";
		//				break;
		//			case ("invalid-input-secret"):
		//				ViewBag.Message = "The secret parameter is invalid or malformed.";
		//				break;

		//			case ("missing-input-response"):
		//				ViewBag.Message = "The response parameter is missing.";
		//				break;
		//			case ("invalid-input-response"):
		//				ViewBag.Message = "The response parameter is invalid or malformed.";
		//				break;

		//			default:
		//				ViewBag.Message = "Error occured. Please try again";
		//				break;
		//		}
		//	}
		//	else
		//	{
		//		ViewBag.Message = "Valid";
		//	}

		//	return View();
		//}
	}
}
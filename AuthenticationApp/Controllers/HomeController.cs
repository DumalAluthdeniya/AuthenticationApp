using AuthenticationApp.Data;
using AuthenticationApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
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
        public IActionResult ViewResource(string resourcePath)
        {
            var fileProvider = new FileExtensionContentTypeProvider();
            // Figures out what the content type should be based on the file name.
            if (!fileProvider.TryGetContentType(resourcePath, out string contentType))
            {
                throw new ArgumentOutOfRangeException($"Unable to find Content Type for file name {resourcePath}.");
            }


            resourcePath = "/ResumeFiles/" + resourcePath;


            return File(resourcePath, contentType);
        }
    }
}
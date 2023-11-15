using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestWebApplication1.Models;

namespace TestWebApplication1.Controllers
{
    public class ManageUserController : Controller
    {
        private readonly ILogger<ManageUserController> _logger;

        public ManageUserController(ILogger<ManageUserController> logger)
        {
            _logger = logger;
        }

        public IActionResult ManageUser()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
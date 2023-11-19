using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication1.Controllers
{
    public class ActivityLoggingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewDetail()
        {
            return View();
        }
    }
}

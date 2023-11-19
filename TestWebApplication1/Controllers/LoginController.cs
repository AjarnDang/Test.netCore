using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication1.Controllers
{
    public class ManageUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EditUser()
        {
            return View();
        }
    }
}

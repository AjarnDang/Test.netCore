﻿using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication1.Controllers
{
    public class ManageRoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EditRole()
        {
            return View();
        }
    }
}

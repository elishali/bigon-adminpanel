﻿using Microsoft.AspNetCore.Mvc;

namespace Bigon.WebUI.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}

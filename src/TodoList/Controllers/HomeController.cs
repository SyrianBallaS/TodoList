﻿using Microsoft.AspNet.Mvc;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

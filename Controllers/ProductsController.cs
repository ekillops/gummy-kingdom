﻿using Microsoft.AspNetCore.Mvc;


namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

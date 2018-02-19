using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangazonWebApp.Models;
using System.Diagnostics;


namespace BangazonWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductCreate()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


    }
}

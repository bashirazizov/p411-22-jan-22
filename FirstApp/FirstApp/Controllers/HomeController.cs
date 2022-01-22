using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //public IActionResult Index(string name, string surname)
        //{
        //    ViewData["name"] = name;
        //    ViewBag.surname = surname;
        //    return View();
        //}

        public IActionResult About(bool haveSeenHome)
        {
            //ViewBag.name = "Mamed";
            TempData["name"] = "Mamed";
            if (haveSeenHome)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

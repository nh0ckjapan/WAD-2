using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home    
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration r)
        {
            return View(r);
        }
        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }
    }
}

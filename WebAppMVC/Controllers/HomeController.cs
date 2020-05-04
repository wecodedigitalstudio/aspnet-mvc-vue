using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Dault
        public ActionResult Index()
        {
            //return RedirectToRoute("About.html");
            var staticPageToRender = new FilePathResult("~/app/index.html", "text/html");
            return staticPageToRender;
            //return View();
        }
    }
}
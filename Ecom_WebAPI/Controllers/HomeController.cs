using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Us Page";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Title = "Products Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Us Page";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Title = "Blog Page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Blog Page";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Blog Page";

            return View();
        }
    }
}

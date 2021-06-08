using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom_WebAPI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Panel
        public ActionResult Login()
        {
            return View();
        }
    }
}
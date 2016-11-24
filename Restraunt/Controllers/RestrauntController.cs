using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restraunt.Controllers
{
    public class RestrauntController : Controller
    {
        // GET: Restraunt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
    }
}
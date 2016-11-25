using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restraunt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Menu = "  We plan to bring sizzling spices of Karahi in the forms of . Dhaba karahi is unique for its roadside dhaba flavors that are made by villagers in India. Chikkar cholay (Channa or Chickpea Masala) is a heartwarming recipe passed down from cholay experts in Punjab. l translate the unmatched flavors brought all the way from Lahore.";
            ViewBag.inspriration = "why we are making this restraunt";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us here:-";
            

            return View();
        }
    }
}
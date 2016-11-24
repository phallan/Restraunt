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
            ViewBag.Message = "To make specialty Punjabi food with affordable prices and exceptional service. We believe in the art of balancing - between more flavor and less burden on the pocket.\br Desi Eh has a delicious list of main dishes.  We plan to bring sizzling spices of Karahi in the forms of chicken karahi, mutton karahi, chicken hari mirch and dhaba karahi. Dhaba karahi is unique for its roadside dhaba flavors that are made by villagers in Pakistan. Chikkar cholay (Channa or Chickpea Masala) is a heartwarming recipe passed down from cholay experts in Punjab. Barbeque dishes such as seekh kebabs and Malai boti will translate the unmatched flavors brought all the way from Lahore. Another highlight in the menu is the special Biryani for all rice lovers out there..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us here:-";

            return View();
        }
    }
}
using System.Web.Mvc;

namespace GettingApiDataAfterAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
            
        }

        public ActionResult LogOut()
        {
            return View();
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
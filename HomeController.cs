using System.Web.Mvc;

namespace MvcSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET 4.8 Application!";
            return View();
        }
    }
}

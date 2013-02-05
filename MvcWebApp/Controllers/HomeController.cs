using MvcWebApp.Helpers;
using System.Web.Mvc;

namespace MvcWebApp.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}

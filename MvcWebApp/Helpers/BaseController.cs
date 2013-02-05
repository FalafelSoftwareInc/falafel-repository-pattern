using MvcWebApp.Models.Data;
using System.Collections;
using System.Linq;
using System.Web.Mvc;

namespace MvcWebApp.Helpers
{
    public class BaseController : Controller
    {
        protected IRepository DataStore { get; set; }

        public BaseController()
        {
            //TODO: USE DEPENDENCY INJECTION FOR DECOUPLING
            this.DataStore = new EFRepository();
        }

        protected IEnumerable GetModelErrors()
        {
            return this.ModelState.SelectMany(x => x.Value.Errors.Select(error => error.ErrorMessage));
        }
    }
}
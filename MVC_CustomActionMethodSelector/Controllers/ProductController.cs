using System.Web.Mvc;
using MVC_CustomActionMethodSelector.Models;
using MVC_CustomActionMethodSelector.CustomActioMethodSelector;

namespace MVC_CustomActionMethodSelector.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [ElectronicsActionMethodSelector]
        public ActionResult GetElectronics()
        {
            var ds = new DataAccessElectronics();
            var products = ds.GetDataElectronics();
            return View("IndexElectronics", products);
        }
        [MechanicalActionMethodSelector]
        public ActionResult GetMechanical()
        {
            var ds = new DataAccessMechanical();
            var products = ds.GetDataMechanical();
             return View("IndexMechanical", products);
        }

    }
}
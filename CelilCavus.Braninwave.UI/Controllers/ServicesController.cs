using CelilCavus.Braninwave.Model.Repository;
using System.Web.Mvc;

namespace CelilCavus.Braninwave.UI.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ServicesRepository _context;

        public ServicesController()
        {
            _context = new ServicesRepository();
        }

        public ActionResult Services()
        {
            var result = _context.GetAll();
            return View(result);
        }
    }
}
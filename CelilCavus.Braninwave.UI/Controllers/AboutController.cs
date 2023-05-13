using CelilCavus.Braninwave.Model.Repository;
using System.Linq;
using System.Web.Mvc;

namespace CelilCavus.Braninwave.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutRepository _context;

        public AboutController()
        {
            _context = new AboutRepository();
        }

        public ActionResult Index()
        {
            var result = _context.GetAll().LastOrDefault();
            return View(result);
        }
    }
}
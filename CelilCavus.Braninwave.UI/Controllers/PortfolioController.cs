using CelilCavus.Braninwave.Model.Repository;
using System.Web.Mvc;

namespace CelilCavus.Braninwave.UI.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly PortfolioRepository _context;

        public PortfolioController()
        {
            _context = new PortfolioRepository();
        }

        public ActionResult Portfolio()
        {
            var result = _context.GetAll();
            return View(result);
        }
    }
}
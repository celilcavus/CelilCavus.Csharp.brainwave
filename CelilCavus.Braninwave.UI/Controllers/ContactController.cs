using CelilCavus.Braninwave.Entity.Entitys;
using CelilCavus.Braninwave.Model.Repository;
using System.Web.Mvc;

namespace CelilCavus.Braninwave.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactRepository _context;

        public ContactController()
        {
            _context = new ContactRepository();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(Contact contact)
        {
            _context.Add(contact);
            return View();
        }
    }
}
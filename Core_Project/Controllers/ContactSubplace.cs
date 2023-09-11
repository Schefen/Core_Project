using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ContactSubplace : Controller
    {
        ContactManager _contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index(int id)
        {
            var value = _contactManager.TGetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactManager.TUpdate(contact);
            return RedirectToAction("Index","Default");
        }
    }
}

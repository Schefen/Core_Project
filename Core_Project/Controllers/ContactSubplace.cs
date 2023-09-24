using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
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

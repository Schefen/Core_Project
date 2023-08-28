using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ServiceController : Controller
    {
        ServicesManager _serviceManager = new ServicesManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmelerim";
            var values = _serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Ekleme Sayfası";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceValidator serviceValidator = new ServiceValidator();
            ValidationResult results = serviceValidator.Validate(service); 
            if (results.IsValid)
            {
                _serviceManager.TAdd(service);
                return RedirectToAction("Index","Default");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.v2 = "Hizmetler";
                    ViewBag.v3 = "Hizmet Ekleme Sayfası";
                }
            }
            return View();
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceManager.TGetById(id);
            _serviceManager.TDelete(value);
            return RedirectToAction("Index","Default");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Güncelleme Sayfası";
            var value = _serviceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceManager.TUpdate(service);
            return RedirectToAction("Index","Default");
        }
    }
}

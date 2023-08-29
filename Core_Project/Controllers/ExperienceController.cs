using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Project.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimlerim";
            var values = _experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme Sayfası";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ExperienceValidator experienceValidator = new ExperienceValidator();
            ValidationResult results = experienceValidator.Validate(experience);
            if (results.IsValid)
            {
                _experienceManager.TAdd(experience);
                return RedirectToAction("Index","Experience");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.v2 = "Deneyimler";
                    ViewBag.v3 = "Deneyim Ekleme Sayfası";
                }
            }
            return View();
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = _experienceManager.TGetById(id);
            _experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme Sayfası";
            var value = _experienceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}

using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yeteneklerim";
            var values = _skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme Sayfası";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            SkillValidator skillValidator = new SkillValidator();
            ValidationResult results = skillValidator.Validate(skill);
            if (results.IsValid)
            {
                _skillManager.TAdd(skill);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.v2 = "Yetenekler";
                    ViewBag.v3 = "Yetenek Ekleme Sayfası";
                }
            }
            return View();
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = _skillManager.TGetById(id);
            _skillManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme Sayfası";
            var value = _skillManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            _skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}

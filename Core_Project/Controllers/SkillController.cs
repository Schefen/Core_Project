﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
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
            _skillManager.TAdd(skill);
            return RedirectToAction("Index");
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

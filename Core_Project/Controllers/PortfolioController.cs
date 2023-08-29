using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Projelerim";
            var values = _portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekleme Sayfası";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult results = portfolioValidator.Validate(portfolio);
            if (results.IsValid)
            {
                _portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index","Portfolio");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.v2 = "Projeler";
                    ViewBag.v3 = "Proje Ekleme Sayfası";
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = _portfolioManager.TGetById(id);
            _portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Güncelleme Sayfası";
            var value = _portfolioManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult results = portfolioValidator.Validate(portfolio);
            if (results.IsValid)
            {
                _portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    ViewBag.v2 = "Projeler";
                    ViewBag.v3 = "Proje Güncelleme Sayfası";
                }
            }
            return View();
        }

    }
}

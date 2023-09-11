using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager _socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = _socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index","SocialMedia");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaManager.TGetById(id);
            _socialMediaManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var value = _socialMediaManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}

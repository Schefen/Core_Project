using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = _skillManager.TGetList();
            return View(values);
        }
    }
}

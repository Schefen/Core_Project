using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Where(x => x.MessageStatus == false).Count();
            ViewBag.v3 = _context.Messages.Where(x => x.MessageStatus == true).Count();
            ViewBag.v4 = _context.Experiences.Count();
            return View();

        }
    }
}

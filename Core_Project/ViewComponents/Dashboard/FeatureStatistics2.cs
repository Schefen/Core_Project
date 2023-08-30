using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureStatistics2 : ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Portfolios.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Services.Count();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureVisitorsByCountries : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

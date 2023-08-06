using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_Project.ViewComponents.Services
{
    public class ServicesList : ViewComponent
    {
        ServicesManager _servicesManager = new ServicesManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = _servicesManager.TGetList();
            return View(values);
        }
    }
}

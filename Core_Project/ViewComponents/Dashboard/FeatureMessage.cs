using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureMessage : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = _messageManager.TGetList().Take(4).ToList();
            return View(values);
        }
    }
}

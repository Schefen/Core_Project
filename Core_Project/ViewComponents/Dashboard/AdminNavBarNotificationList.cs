using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class AdminNavBarNotificationList : ViewComponent
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = _announcementManager.TGetList().OrderByDescending(x => x.AnnouncementId).Take(4).ToList();
            return View(values);
        }
    }
}

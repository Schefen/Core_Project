using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    
    public class DashboardController : Controller
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminAnnouncementDetails(int id)
        {
            Announcement announcement = _announcementManager.TGetById(id);
            return View(announcement);
        }
    }
}

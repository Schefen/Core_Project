using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterDashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public WriterDashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.WriterUserName + " " + values.WriterUserSurname;
            // Weather Api
            string apikey = "a25c24328f096c5e2c2e088c8e15992e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + apikey;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //statistics
            Context context = new Context();
            ViewBag.v1 = context.WriterMessages.Where(x=>x.WriterMessageReceiver==values.UserName).Count();
            ViewBag.v2 = context.WriterMessages.Where(x=>x.WriterMessageSender==values.UserName).Count();
            ViewBag.v3 = context.Users.Count();
            ViewBag.v4 = context.Announcements.Count();

            return View();
        }
    }
}

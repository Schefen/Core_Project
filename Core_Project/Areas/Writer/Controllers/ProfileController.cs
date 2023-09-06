using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        public readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.WriterUserName;
            model.Surname = values.WriterUserSurname;
            model.PictureUrl = values.WriterUserImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Picture!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditViewModel.Picture.CopyToAsync(stream);
                user.WriterUserImageUrl = imagename;
            }
            user.WriterUserName = userEditViewModel.Name;
            user.WriterUserSurname = userEditViewModel.Surname;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Default");
            }
            return View();
        }
    }
}

using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Core_Project.ViewComponents.Experience
{
    
    public class ExperienceList : ViewComponent
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }

    }
}

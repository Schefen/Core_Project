﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureMessage : ViewComponent
    {
        UserMessageManager _userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = _userMessageManager.GetUserMessagesWithUserService();
            return View(values);
        }
    }
}

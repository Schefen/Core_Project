﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = _messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _messageManager.TGetById(id);
            _messageManager.TDelete(value);
            return RedirectToAction("Index","Contact");
        }
        public IActionResult GetContactDetails(int id)
        {
            var values = _messageManager.TGetById(id);
            return View(values);
        }
    }
}

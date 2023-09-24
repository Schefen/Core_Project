using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult AdminInbox()
        {
            string p = "Admin";
            var values = _writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult AdminSendbox()
        {
            string p = "Admin";
            var values = _writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminInboxDetails(int id)
        {
            var values = _writerMessageManager.TGetById(id);
            return View(values);
        }
        public IActionResult AdminSendboxDetails(int id)
        {
            var values = _writerMessageManager.TGetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult AdminMessageSender() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminMessageSender(WriterMessage writerMessage)
        {
            writerMessage.WriterMessageSender = "Admin";
            writerMessage.WriterMessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("AdminSendbox");
        }
    }
}

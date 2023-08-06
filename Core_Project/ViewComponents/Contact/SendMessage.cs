using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {

        MessageManager _messageManager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message msg)
        //{
        //    msg.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    msg.MessageStatus = true;
        //    _messageManager.TAdd(msg);
        //    return View();
        //}
    }
}

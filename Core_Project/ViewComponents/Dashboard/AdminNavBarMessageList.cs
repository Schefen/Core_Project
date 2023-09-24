using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class AdminNavBarMessageList : ViewComponent
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "Admin";
            var values = _writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageId).Take(4).ToList();
            return View(values);
        }
    }
}

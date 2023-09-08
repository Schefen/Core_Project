using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [Route("")]
        [Route("GetReceiverMessage")]
        public async Task<IActionResult> GetReceiverMessage(string value)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            value = values.UserName;
            var messageList = _writerMessageManager.GetListReceiverMessage(value);
            return View(messageList);
        }
        [Route("")]
        [Route("GetSenderMessage")]
        public async Task<IActionResult> GetSenderMessage(string value)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            value = values.UserName;
            var messageList = _writerMessageManager.GetListSenderMessage(value);
            return View(messageList);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.TGetById(id);
            return View(writerMessage);
        }
        [Route("SenderMessageDetails/{id}")]
        public IActionResult SenderMessageDetails(int id)
        {
            WriterMessage writerMessage = _writerMessageManager.TGetById(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string username = values.UserName;
            writerMessage.WriterMessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessage.WriterMessageSender = username;
            _writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("GetSenderMessage");
        }
    }
}

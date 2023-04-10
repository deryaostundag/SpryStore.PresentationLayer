using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequestViewModel model) 
        { 
            MimeMessage mimeMessage= new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress(name: "Admin", address: "dryostundag@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAdressTo = new MailboxAddress(name: "User", address: model.ReceiverMail);
            mimeMessage.To.Add(mailboxAdressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient Client = new SmtpClient();
            Client.Connect("smtp.gmail.com", 587, false);
            Client.Authenticate("dryostundag@gmail.com", "dofofroukqshzsiw");
            Client.Send(mimeMessage);
            Client.Disconnect(true);

            return View();
        }
    }
}

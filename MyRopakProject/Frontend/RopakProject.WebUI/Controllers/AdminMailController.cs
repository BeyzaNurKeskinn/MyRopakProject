using RopakProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace RopakProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddresFrom = new MailboxAddress("RopakAdmin", "beyzanurhorasan89@gmail.com");
            mimeMessage.From.Add(mailboxAddresFrom);

            MailboxAddress mailboxAddresTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddresTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("beyzanurhorasan89@gmail.com", "ejeedluvrijmkgyn");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}

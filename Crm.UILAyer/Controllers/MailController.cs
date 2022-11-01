using Crm.UILAyer.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Controllers
{
   
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //xaektmdyrhfoyavx
        }
        [HttpPost]
        public IActionResult Index( MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressfrom = new MailboxAddress("Proje Admin", "snglymn@gmail.com");//normalde bu kısımda user bilgileri çekilmesi gerekiyor//
            mimeMessage.From.Add(mailboxAddressfrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", p.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = p.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody();
            mimeMessage.Subject = p.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("snglymn@gmail.com", "xaektmdyrhfoyavx");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
            //xaektmdyrhfoyavx
        }
    }

}

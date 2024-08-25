using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PostgreSQLCafe.Dto.MailDto;

namespace PostgreSQLCafe.Controllers
{
    public class SignalRAdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Mail(CreateMailDto createMailDto)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressfrom = new MailboxAddress("SignalR Rezervasyon", "kaanonkaya@gmail.com");
            mimeMessage.From.Add(mailboxAddressfrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = createMailDto.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = createMailDto.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("kaanonkaya@gmail.com", "xxxx xxxx xxxx xxxx");

            client.Send(mimeMessage);
            client.Disconnect(true);

            return View("Index");
        }
    }
}

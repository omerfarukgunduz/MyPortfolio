using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    [Authorize]

    public class MessageController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Inbox()
		{

            var values = context.Messages.ToList();
            return View(values);
		}

		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value= context.Messages.Find(id);
			value.IsRead=true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

		public IActionResult DeleteMessage(int id) 
		{
			var value=context.Messages.Find(id);
			context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

		public IActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
			return View(value);	
		}

		[HttpGet]
		public IActionResult MessageSend(int id) 
		{
		return View(context.Messages.Find(id));
		}

		[HttpPost]
		public IActionResult MessageSend(Mail mail)
		{
			var mailadrs = context.Tokens.FirstOrDefault()?.MailAddress;
			var ownername = context.Tokens.FirstOrDefault()?.OwnerName;

			MimeMessage mimeMessage = new MimeMessage();
			MailboxAddress mailboxAddressFrom = new MailboxAddress($"{ownername}", $"{mailadrs}");
			mimeMessage.From.Add(mailboxAddressFrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("Visitor", mail.ReceiverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody=mail.Body;
			mimeMessage.Body=bodyBuilder.ToMessageBody();



			mimeMessage.Subject = mail.Subject;

			var password = context.Tokens.FirstOrDefault()?.Password;

			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate($"{mailadrs}", $"{password}");
			client.Send(mimeMessage);
			client.Disconnect(true);

			return RedirectToAction("Inbox");
		}

	}
}

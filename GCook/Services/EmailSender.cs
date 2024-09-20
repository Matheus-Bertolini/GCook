
using System.Net;
using System.Net.Mail;

namespace GCook.Services;

    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string emailAdress, string subject, string htmlMessage)
        {
            var mail = "gcook.app@outlook.com";
            var pw = "QV3E4khpZBEcL7K";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            MailMessage sendMail = new(
                from: mail,
                to: emailAdress,
                subject,
                htmlMessage
            );
            sendMail.IsBodyHtml = true;

            await client.SendMailAsync(sendMail);
        }
    }

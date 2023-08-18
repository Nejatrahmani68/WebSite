using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace DataAccess.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _config;

        public EmailSender(IConfiguration config)
        {
            _config = config;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient client = new SmtpClient
            {
                Port =Int32.Parse(_config.GetSection("MailSettings").GetSection("Port").Value),
                Host = _config.GetSection("MailSettings").GetSection("Host").Value,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_config.GetSection("MailSettings").GetSection("Mail").Value, _config.GetSection("MailSettings").GetSection("Password").Value)
            };

            return client.SendMailAsync(_config.GetSection("MailSettings").GetSection("Mail").Value, email, subject, htmlMessage);
        }
    }
}

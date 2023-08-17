using DataAccess.Data;
using DataAccess.Services;
using Microsoft.Extensions.Configuration;
using Model;
using System.Data.Entity;
using System.Net.Mail;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebsitePresentation.Areas.ArmyMembersArea.Controllers
{
    public class ServiceTelegramBotControl
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _iConfig;

        public ServiceTelegramBotControl(ApplicationDbContext context, IConfiguration iConfig)

        {
            _context = context;
            _iConfig = iConfig;
        }
        //Telegram Bot Configuration
        public void SendBotMessage(int armyPostDetailsId)
        {
            try
            {
                var armypost = _context.ArmyPostDetails!.Find(armyPostDetailsId);
                string message = "سڵاوو ڕێز" + System.Environment.NewLine + "هاوڕێیان تکایە پۆستی  " + armypost!.Name!.ToString() + "  بە لینکی  " + armypost.Link!.ToString() + System.Environment.NewLine + FindConfigurationArmyPost(armypost) + System.Environment.NewLine;
                var bot = new Telegram.Bot.TelegramBotClient("6379023493:AAGWRR6MsDT9D87wtfwUZJz9U_6D8jktiDk");
                foreach (var item in _context.ArmyMembersAccounts!.Where(m => m.Active == true && m.ArmySocialsName!.Title == "Telegram"))
                {
                   bot.SendTextMessageAsync(item.SocialAddress!, message);
                }

            }
            catch
            {

            }
        }
        public void SendMail(int armyPostDetailsId)
        {
            try
            {
                var armypost = _context.ArmyPostDetails!.Find(armyPostDetailsId);
                string message = "سڵاوو ڕێز" + System.Environment.NewLine + "هاوڕێیان تکایە پۆستی  " + armypost!.Name!.ToString() + "  بە لینکی  " + armypost.Link!.ToString() + System.Environment.NewLine + FindConfigurationArmyPost(armypost) + System.Environment.NewLine;
                MailMessage mail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient(_iConfig.GetSection("MailSettings").GetSection("Host").Value);
                mail.From = new MailAddress(_iConfig.GetSection("MailSettings").GetSection("Mail").Value);
                mail.Subject = _iConfig.GetSection("MailSettings").GetSection("DisplayName").Value;
                mail.Body = message;
                smtpserver.Port = Int32.Parse(_iConfig.GetSection("MailSettings").GetSection("Port").Value);
                smtpserver.EnableSsl = true;
                smtpserver.Credentials = new System.Net.NetworkCredential(_iConfig.GetSection("MailSettings").GetSection("Mail").Value, _iConfig.GetSection("MailSettings")!.GetSection("Password").Value);
                foreach (var item in _context.ArmyMembers!.Where(m => m.Active == true && m.MemberEmail != null))
                {
                    mail.To.Add(item.MemberEmail!.ToString());
                    smtpserver.Send(mail);
                }
            }
            catch
            {

            }
        }
        public string FindConfigurationArmyPost(ArmyPostDetails armyPostDetails)
        {
            string message = "";
            if (armyPostDetails.Save)
            {
                message += " (Save) سەیڤ " + System.Environment.NewLine;
            }
            if (armyPostDetails.Block)
            {
                message += " (Block) بلاک " + System.Environment.NewLine;
            }
            if (armyPostDetails.Twit)
            {
                message += " (Twit) تویت " + System.Environment.NewLine;
            }
            if (armyPostDetails.CommentNegetive)
            {
                message += " (Comment -) کۆمێنتی نێگێتیڤ " + System.Environment.NewLine;
            }
            if (armyPostDetails.CommentPssitive)
            {
                message += " (Comment +) کۆمێنتی پۆزێتیڤ " + System.Environment.NewLine;
            }
            if (armyPostDetails.Like)
            {
                message += " (Like) لایک " + System.Environment.NewLine;
            }
            if (armyPostDetails.Report)
            {
                message += " (Report) ڕیپۆرت " + System.Environment.NewLine;
            }
            if (armyPostDetails.ShareAsPost)
            {
                message += " (Share as Post) هاوبەش کردن بە پۆست " + System.Environment.NewLine;
            }
            if (armyPostDetails.ShareAsStory)
            {
                message += " (Share as Story) هاوبەش کردن بە ستۆری " + System.Environment.NewLine;
            }
            message += " بکەن .";
            if (armyPostDetails.Description != null)
            {
                message += System.Environment.NewLine + " ** تێبینی ** " + System.Environment.NewLine + armyPostDetails.Description;
            }
            return message;
        }

    }
}

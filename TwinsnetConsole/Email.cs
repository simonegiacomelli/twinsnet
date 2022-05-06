using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class Email
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"I'm {nameof(Email)}");

            if (!File.Exists("password.txt"))
                throw new Exception("Manca il file password.txt");

            var password = File.ReadAllText("password.txt");

            // MailMessage e' la classe che conosce e manipola il file di test (.eml) di una email
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress("fests@simone.pro", "Fests Giacomelli");
            Msg.To.Add("simone.giacomelli@gmail.com");
            Msg.Subject = $"twinsnet console {DateTime.Now}";
            Msg.Body = "body1\n123456789012345678901234567890\n\nCiao da Fests.";
            Msg.ReplyToList.Add(new MailAddress("info@simone.pro", "Info Giacomelli"));
            Msg.Attachments.Add(new Attachment("logo.png"));


            // fix sicurezza gmail 
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("fests@simone.pro", password );
            smtp.EnableSsl = true;
            smtp.Send(Msg);
        }
    }
}

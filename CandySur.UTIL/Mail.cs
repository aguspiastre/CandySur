using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.UTIL
{
    public class Mail
    {
        public static void EnviarMail(string mailUsuario, string asunto, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("candy.sur.lomas@gmail.com");
            mail.To.Add(mailUsuario);
            mail.Subject = asunto;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("candy.sur.lomas", "candysur123");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}

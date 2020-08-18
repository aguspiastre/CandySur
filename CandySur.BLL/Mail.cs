using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BLL
{
    public class Mail
    {
        public static void EnviarMail(string cliente, string mailUsuario, string asunto, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("agustin.e.piastrellini@gmail.com");
            mail.To.Add(mailUsuario);
            mail.Subject = asunto;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

    }
}

using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace AppModelo.Model.Infra.Services
{
    public class EmailService
    {
        public bool EnviarEmail(string nome, string email, string assunto, string mensagem)
        {
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("Sistema Senai", "user_senai_temp@faceli.edu.br"));
                mimeMessage.To.Add(new MailboxAddress(nome, email));
                mimeMessage.Subject = assunto;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = mensagem
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);

                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

                    client.Send(mimeMessage);
                    client.Disconnect(true);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

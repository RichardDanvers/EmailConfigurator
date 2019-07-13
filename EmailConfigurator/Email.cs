using System;
using System.Net;
using System.Net.Mail;

namespace EmailConfigurator
{
    public static class Email
    {
        public static void Send(MailMessage message, Configuration settings)
        {

            SmtpClient client = new SmtpClient
            {
                EnableSsl = settings.Ssl,
                Credentials = (ICredentialsByHost)new System.Net.NetworkCredential(settings.Username, settings.Password),
                Host = settings.SmtpHost
            };

            client.Send(message);
        }

    }
}

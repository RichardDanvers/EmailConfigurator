using System;
using System.Net;
using System.Net.Mail;

namespace EmailConfigurator
{
    /// <summary>
    /// Use the static methods within this class to send an email.
    /// </summary>
    public static class Email
    {
        /// <summary>
        /// Sends email using provided mail message object and smtp configuration settings
        /// </summary>
        /// <param name="message"></param>
        /// <param name="settings"></param>
        public static void Send(MailMessage message, Configuration settings)
        {

            SmtpClient client = new SmtpClient
            {
                EnableSsl = settings.Ssl,
                Credentials = new NetworkCredential(settings.Username, settings.Password),
                Host = settings.SmtpHost
            };

            client.Send(message);
        }

    }
}

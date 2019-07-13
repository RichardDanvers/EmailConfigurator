using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EmailConfigurator
{
    /// <summary>
    /// Set this class to your smtp server options and then pass in to the Email.Send method.
    /// </summary>
    public class Configuration
    {
        public string SmtpHost { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Ssl { get; set; }
    }
}

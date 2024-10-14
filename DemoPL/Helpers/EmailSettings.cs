using Demo.DAL.Model;
using DemoPL.Settings;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net;
using System.Net.Mail;

namespace DemoPL.Helpers
{
    public class EmailSettings :ImailSetting
	{
		private  IOptions<MailSetting> _options;

		public EmailSettings(IOptions<MailSetting> options)
        {
			_options = options;
		}

        public static void SendEmail(Email email)
        {
            var client = new SmtpClient("stmp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("am5302817@gmail.com", "xzesnicenjvquflu");
            client.Send("am5302817@gmail.com", email.To, email.Subject, email.Body);



        }

		public void Sendmail(Email email)
		{
			var mail = new MimeMessage
			{
				Sender = MailboxAddress.Parse(_options.Email),
				Subject = email.Subject,

			};

		}
	}
}

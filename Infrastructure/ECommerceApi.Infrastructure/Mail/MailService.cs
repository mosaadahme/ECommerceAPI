using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Security;


namespace ECommerceApi.Infrastructure.Mail
{
    public class MailService : Application.Interfaces.Mail.IMailService
    {
        private readonly MailSettings mailSettings;

        public MailService(IOptions<MailSettings> configuration)
        {
             this.mailSettings = configuration.Value;
        }


        public async Task SendMessageAsync(string to, string subject, string body, IFormFileCollection? files = null)
        {
          await SendMessageAsync(new string[] {to },subject,body,files);
        }

        public async Task SendMessageAsync(IList<string> tos, string subject, string body,IFormFileCollection? files = null)
        {
          MimeMessage email=  new MimeMessage()
            {
                Sender = MailboxAddress.Parse(mailSettings.Email),
                Subject = subject,
            };
            foreach (var emailTo in tos)
            {
                email.To.Add(MailboxAddress.Parse(emailTo));
            }

            BodyBuilder bodyOfMessage = new BodyBuilder();

            if (files?.Count>0)
            {
                foreach (var file in files) 
                {
                    byte[] DataOfFiles;
                    if (file.Length>0)
                    {
                        await using var memStream = new MemoryStream(); 
                        await file.CopyToAsync(memStream);
                        DataOfFiles = memStream.ToArray();
                        bodyOfMessage.Attachments.Add(file.FileName,DataOfFiles,ContentType.Parse(file.ContentType));
                    }
                }

            }

            bodyOfMessage.HtmlBody = body;

            email.Body=bodyOfMessage.ToMessageBody();
            email.From.Add(new MailboxAddress(mailSettings.DisplayName, mailSettings.Email));

            using var smtp=new SmtpClient();
            smtp.Connect(mailSettings.Host,mailSettings.Port,SecureSocketOptions.StartTls);
            smtp.Authenticate(mailSettings.Email, mailSettings.Password);
            await smtp.SendAsync(email);

            smtp.Disconnect(true);

        }
    }
}

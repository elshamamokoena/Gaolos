using Gaolos.Application.Contracts.Infrastructure;
using Gaolos.Application.Models.Mail;
using MailKit.Security;
using MailKit;
using Microsoft.Extensions.Options;
using MimeKit;
using Org.BouncyCastle.Asn1.Pkcs;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Runtime;
using MailKit.Net.Smtp;
using System.Text;
using RazorEngineCore;
using System.Reflection;

namespace Gaolos.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public EmailSettings _settings { get; }

        public EmailService(IOptions<EmailSettings> mailSettings)
        {
            _settings = mailSettings.Value;
        }

        public async Task<bool> SendAsync(Email email, CancellationToken cancellationToken)
        {
                try
                {
                    // Initialize a new instance of the MimeKit.MimeMessage class
                    var mail = new MimeMessage();

                    #region Sender / Receiver
                    // Sender
                    mail.From.Add(new MailboxAddress(_settings.DisplayName, email.From ?? _settings.From));
                    mail.Sender = new MailboxAddress(email.DisplayName ?? _settings.DisplayName, email.From ?? _settings.From);

                    // Receiver
                    foreach (string mailAddress in email.To)
                        mail.To.Add(MailboxAddress.Parse(mailAddress));

                    // Set Reply to if specified in mail data
                    if (!string.IsNullOrEmpty(email.ReplyTo))
                        mail.ReplyTo.Add(new MailboxAddress(email.ReplyToName, email.ReplyTo));

                    // BCC
                    // Check if a BCC was supplied in the request
                    if (email.Bcc != null)
                    {
                        // Get only addresses where value is not null or with whitespace. x = value of address
                        foreach (string mailAddress in email.Bcc.Where(x => !string.IsNullOrWhiteSpace(x)))
                            mail.Bcc.Add(MailboxAddress.Parse(mailAddress.Trim()));
                    }

                    // CC
                    // Check if a CC address was supplied in the request
                    if (email.Cc != null)
                    {
                        foreach (string mailAddress in email.Cc.Where(x => !string.IsNullOrWhiteSpace(x)))
                            mail.Cc.Add(MailboxAddress.Parse(mailAddress.Trim()));
                    }
                    #endregion

                    #region Content

                    // Add Content to Mime Message
                    var body = new BodyBuilder();
                    mail.Subject = email.Subject;
                    body.HtmlBody = email.Body;
                    mail.Body = body.ToMessageBody();

                    #endregion

                    #region Send Mail

                    using var smtp = new SmtpClient();

                    if (_settings.UseSSL)
                    {
                        await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.SslOnConnect, cancellationToken);
                    }
                    else if (_settings.UseStartTls)
                    {
                        await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls, cancellationToken);
                    }
                    await smtp.AuthenticateAsync(_settings.UserName, _settings.Password, cancellationToken);
                    await smtp.SendAsync(mail, cancellationToken);
                    await smtp.DisconnectAsync(true, cancellationToken);

                    #endregion

                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
        }

        public string GetEmailTemplate<T>(string templateName, T Model)
        {
            string emailTemplate = LoadTemplate(templateName);

            IRazorEngine razorEngine = new RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile(emailTemplate);
            return template.Run(Model);
        }
      
        public string LoadTemplate(string templateName)
        {
            string baseDir = Directory.GetCurrentDirectory();
            string templateDir = Path.Combine(baseDir, "Files/MailTemplates");
            string templatePath = Path.Combine(templateDir,$"{templateName}.cshtml" );

            using FileStream fileStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);

            string template = streamReader.ReadToEnd();
            streamReader.Close();
            return template;


            //var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", templateName);
            //return File.ReadAllText(templatePath);
        }



        //public async Task<bool> SendEmail(Email email)
        //{
        //    var client = new SendGridClient(_emailSettings.ApiKey);

        //    var subject = email.Subject;
        //    var to = new EmailAddress(email.To);
        //    var emailBody = email.Body;

        //    var from = new EmailAddress
        //    {
        //        Email = _emailSettings.FromAddress,
        //        Name = _emailSettings.FromName
        //    };

        //    var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
        //    var response = await client.SendEmailAsync(sendGridMessage);

        //    if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
        //        return true;

        //    return false;
        //}
    }
}

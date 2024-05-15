using Gaolos.Application.Models.Mail;

namespace Gaolos.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        //Task<bool> SendEmail(Email email);
        Task<bool> SendAsync(Email email, CancellationToken cancellationToken);
        string GetEmailTemplate<T>(string templateName, T Model);
    }
}

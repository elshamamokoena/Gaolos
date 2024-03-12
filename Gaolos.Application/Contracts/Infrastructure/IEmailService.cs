using Gaolos.Application.Models.Mail;

namespace Gaolos.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}

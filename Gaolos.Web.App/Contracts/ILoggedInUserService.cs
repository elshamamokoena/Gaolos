using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Contracts
{
    public interface ILoggedInUserService
    {
        Task<LoggedInUserViewModel> GetUserDetails();

       // Guid UserId { get; }
        //string Name { get; }
        //string Surname { get; }
        //string Email { get; }
        //string UserId { get; }
    }
}

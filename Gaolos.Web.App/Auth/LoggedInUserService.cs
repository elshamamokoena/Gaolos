using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Gaolos.Web.App.Auth
{
    public class LoggedInUserService : ILoggedInUserService
    {
        private readonly AuthenticationStateProvider _stateProvider;
        public LoggedInUserService(AuthenticationStateProvider authenticationStateProvider)
        {
            _stateProvider = authenticationStateProvider;
        }



        public async Task<LoggedInUserViewModel> GetUserDetails()
        {
            var authState = await ((CookieAuthenticationStateProvider)_stateProvider).GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var name = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
                var surname = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value;
                var email = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                var id = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                return new LoggedInUserViewModel(name, surname, email, id);
            }
            return null;
        }




    }
}

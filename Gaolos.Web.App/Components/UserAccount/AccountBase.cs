using Gaolos.Web.App.Contracts;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public  class AccountBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        public void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);

        }
    }
}

using Gaolos.Web.App.Contracts;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class SideBar
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        protected void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }

    }
}

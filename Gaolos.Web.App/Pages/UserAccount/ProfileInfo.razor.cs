using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class ProfileInfo
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        public UserInfo UserInfo { get; set; }

        protected override void OnInitialized()
        {
        }


        public void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
    }
}

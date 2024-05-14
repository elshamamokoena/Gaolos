using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class SideBar
    {

        [Parameter]
        public int OrderCount { get; set; }

        [Inject]
        public ILoggedInUserService LoggedInUserService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        public LoggedInUserViewModel LoggedInUser { get; set; } 

        protected override async Task OnInitializedAsync()
        {
            LoggedInUser  = await LoggedInUserService.GetUserDetails();
            await base.OnInitializedAsync();
        }

        protected void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }



    }
}

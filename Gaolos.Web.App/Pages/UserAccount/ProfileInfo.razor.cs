using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class ProfileInfo
    {
        [Inject]
        public ILoggedInUserService LoggedInUserService { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public LoggedInUserViewModel LoggedInUser { get; set; }
        protected override async Task OnInitializedAsync()
        {
            LoggedInUser = await LoggedInUserService.GetUserDetails();
            await base.OnInitializedAsync();
        }

    
    }
}

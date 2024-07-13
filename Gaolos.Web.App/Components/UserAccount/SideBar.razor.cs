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
        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var pendingOrders = await AccountDataService.GetOrders(null, null, true, null, 1, 10, null);
            OrderCount = pendingOrders.TotalCount;
            LoggedInUser  = await LoggedInUserService.GetUserDetails();
            await base.OnInitializedAsync();
        }

        protected override Task OnParametersSetAsync()
        {
            StateHasChanged();
            return base.OnParametersSetAsync();
        }

        protected void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }



    }
}

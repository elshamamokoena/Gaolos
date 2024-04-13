using Gaolos.Web.App.Auth;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Gaolos.Web.App.Shared
{
    public partial class NavBar
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected async override Task OnInitializedAsync()
        {
           var state= await ((CookieAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();
        }
    }
}

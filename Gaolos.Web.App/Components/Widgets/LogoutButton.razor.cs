using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Widgets
{
    public partial class LogoutButton
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public async Task Logout()
        {
            await AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
    }
}

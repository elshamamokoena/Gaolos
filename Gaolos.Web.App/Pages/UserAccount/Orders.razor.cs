using Gaolos.Web.App.Contracts;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class Orders
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }


        public void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
    }
}

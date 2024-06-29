using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class OrderTracking
    {
        [Parameter]
        public Guid OrderId { get; set; }
        [Inject]
        public IAccountDataService OrderDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ILoggedInUserService loggedInUserService { get; set; }

        private OrderViewModel  _order { get; set; }



        protected override async Task OnInitializedAsync()
        {
            await GetOrder();
        }

        private async Task GetOrder()
        {
            _order = await OrderDataService.GetOrder(OrderId);
        }
    }
}

using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace Gaolos.Web.App.Pages
{
    public partial class OrderTracking
    {
        [Parameter]
        public Guid OrderId { get; set; }
        [Parameter]
        [SupplyParameterFromQuery(Name = "OrderId")]
        public Guid OrderIdFromQuery { get; set; }
        [Inject]
        public IAccountDataService OrderDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ILoggedInUserService loggedInUserService { get; set; }

        private OrderViewModel ? _order { get; set; }
        private OrderViewModel? _selectedOrder { get; set; }

        private PagedOrdersViewModel _orders { get; set; } 
            = new PagedOrdersViewModel();


        protected override async Task OnInitializedAsync()
        {

            if(!string.IsNullOrWhiteSpace(GetUri()))
            {
                OrderIdFromQuery = Guid.Parse(GetUri());
                await GetOrder(OrderIdFromQuery);
                return;
            }

            _selectedOrder = new OrderViewModel();

            var user = await loggedInUserService.GetUserDetails();
            if (user != null) 
                _orders = await OrderDataService.GetOrders("OrderId",null, true, "",1,10,"");
        }
        private string GetUri()
        {
            var uri= NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("OrderId", out var orderId))
            {
                
                return orderId.ToString();
            }
            return "";
        }
        protected  override async Task OnParametersSetAsync()
        {

            if (OrderId != Guid.Empty)
                await GetOrder(OrderId);

            await base.OnParametersSetAsync();
        }

        private async Task GetOrder(Guid id)
        {

            _order = await OrderDataService.GetOrder(id);
            _selectedOrder = _order;
          
        }
        private async Task ShowOrderDetails(Guid id)
        {
           // _selectedOrder = null;
            _selectedOrder= await OrderDataService.GetOrder(id);
        }

        private async Task CloseOrderDetails()
        {
            _selectedOrder = null;
        }
    }
}

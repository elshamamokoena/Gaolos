using Gaolos.Web.App.Components;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class Orders
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        private PaginatedList<OrderViewModel> paginatedList = 
            new PaginatedList<OrderViewModel>();
        private IEnumerable<OrderViewModel> ordersList;
        private IEnumerable<OrderViewModel> newOrders;

        private string orderBy = "OrderStatus";
        private string searchQuery= string.Empty;
        private int ? pageNumber = 1;
        private int? pageSize = 5;
        private string?  fields = string.Empty;
        private OrderStatus ? orderStatus;
        private OrderViewModel ?_selectedOrder { get; set; }

        private async Task SelectOrder(OrderViewModel order)
        {
            _selectedOrder = await AccountDataService.GetOrder(order.OrderId);
        }
        protected override async Task OnInitializedAsync()
        {
            var orders = await AccountDataService.GetOrders(orderBy, orderStatus ,searchQuery, pageNumber.Value, pageSize.Value, fields   );
            paginatedList = new PaginatedList<OrderViewModel>(orders.Orders.ToList(), orders.TotalCount, orders.CurrentPage, orders.PageSize);
            ordersList = paginatedList.Items;
            //var user = await AuthenticationService.GetUser();
            //if (user != null)
            //{
            //    var result = await AccountDataService.GetOrdersForUser(user.Id, paginatedList.PageNumber, paginatedList.PageSize);
            //    paginatedList = result;
            //    orders = result.Items;
            //}
        }
        public async void PageIndexChanged(int newPageNumber)
        {
            if (newPageNumber < 1 || newPageNumber > paginatedList.TotalPages)
            {
                return;
            }
            pageNumber = newPageNumber;
            await GetSales();
            StateHasChanged();
        }

        protected async Task GetSales()
        {
            var orders = await AccountDataService.GetOrders(orderBy, orderStatus ,searchQuery, pageNumber.Value, pageSize.Value, fields);
            paginatedList = new PaginatedList<OrderViewModel>(orders.Orders.ToList(), orders.TotalCount, orders.CurrentPage, orders.PageSize);
            ordersList = paginatedList.Items;
            StateHasChanged();
        }

        private async Task FilterByStatus()
        {
            ResetPaging();
            await GetSales();
        }
        private void ResetPaging()
        {
            pageNumber = 1;
        }
        public async Task Logout()
        {
            await AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
    }
}

using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace Gaolos.Web.App.Pages
{
    public partial class OrderConfirmation
    {
        [Parameter]
        [SupplyParameterFromQuery(Name ="orderId")]
        public Guid OrderId { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = "orderNumber")]
        public string OrderNumber { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("OrderId: " + GetUri());
            await base.OnInitializedAsync();
        }
        private string GetUri()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("OrderId", out var orderId))
            {
                return orderId.ToString();
            }
            return "";
        }
        private async Task TrackOrder()
        {
            NavigationManager.NavigateTo($"/track-order/{OrderId}");
        }
    }
}

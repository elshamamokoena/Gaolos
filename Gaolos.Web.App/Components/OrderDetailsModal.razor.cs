using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class OrderDetailsModal
    {
      
        [Parameter]
        public Guid OrderId { get; set; }

        public OrderViewModel? Order { get; set; }

        [Parameter]
        public EventCallback OnClose { get; set; }

        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if(OrderId!=Guid.Empty)
                Order = await AccountDataService.GetOrder(OrderId);
          
            await base.OnParametersSetAsync();
        }

        private async Task Close()
        {
            Order = null;
            await OnClose.InvokeAsync();
        }
    }
}

using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class UpdateAddressModal
    {
        [Parameter]
        public DeliveryAddressViewModel? DeliveryAddress { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }
        public string Message { get; set; }
        [Parameter]
        public EventCallback OnAddressUpdated { get; set; }

        [Parameter]
        public EventCallback OnClose { get; set; }

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }
        protected async void HandleValidSubmit()
        {
            // Call the service to update the address
            await AccountDataService.UpdateDeliveryAddress(DeliveryAddress);
            // Call the parent component to refresh the list of addresses
             await OnAddressUpdated.InvokeAsync();
           
        }
        private async void Close()
        {
              DeliveryAddress = null;
            // Close the modal
            await OnClose.InvokeAsync();
        }
    }
}

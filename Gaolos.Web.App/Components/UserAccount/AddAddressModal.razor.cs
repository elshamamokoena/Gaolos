using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class AddAddressModal
    {
        public DeliveryAddressViewModel DeliveryAddress { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }
        public string Message { get; set; }
        [Parameter]
        public EventCallback OnAddressAdded { get; set; }

        protected override void OnInitialized()
        {
            DeliveryAddress = new DeliveryAddressViewModel();
        }

        protected async void HandleValidSubmit()
        {
            // Call the service to add the address

           var response = await AccountDataService.AddDeliveryAddress(DeliveryAddress);
       
            if (response.Success)
            {
                // Call the parent component to refresh the list of addresses
                await OnAddressAdded.InvokeAsync();
              
                // Close the modal
            }
            else
            {
                Message = "Error adding address";
                foreach (var error in response.ValidationErrors)
                {
                    Console.WriteLine($"{error} \n");
                }
            }


            // Close the modal
        }
    }
}

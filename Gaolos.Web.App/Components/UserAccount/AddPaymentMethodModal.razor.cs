using Gaolos.ComponentLibrary;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class AddPaymentMethodModal
    {
        public PaymentMethodViewModel  PaymentMethod { get; set; }
            = new PaymentMethodViewModel();

        [Parameter]
        public EventCallback OnPaymentMethodAdded { get; set; }
        [Inject]
        public IAccountDataService  AccountDataService { get; set; }
        private string _dateString { get; set; }

        private void FormatDate()
        {
            if(_dateString.Count()==2)
            {

               _dateString += "/";
                Console.WriteLine("Date striiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiing:"+_dateString);
            }
            PaymentMethod.Expiry = _dateString;
        }

        public string Message { get; set; } 
            = string.Empty;
               [Inject]
               public JsInterop JsInterop { get; set; }

  
        private async void HandleValidSubmit()
        {
            // Call the service to add the payment method
            var response = await AccountDataService.AddPaymentMethod(PaymentMethod);

            if (response.Success)
            {
                // Call the parent component to refresh the list of payment methods
                await OnPaymentMethodAdded.InvokeAsync();

                // Close the modal
            }
            else
            {
                Message = "Error adding payment method";
                //foreach (var error in response.ValidationErrors)
                //{
                //    Console.WriteLine($"{error} \n");
                //}
            }


            // Close the modal
        }
    }
}

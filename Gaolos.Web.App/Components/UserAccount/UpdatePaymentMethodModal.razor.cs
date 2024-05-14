using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class UpdatePaymentMethodModal
    {
        [Parameter]
        public PaymentMethodViewModel? PaymentMethod { get; set; }

        [Parameter]
        public EventCallback OnPaymentMethodUpdated { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        [Parameter]
        public EventCallback OnClose { get; set; }

        protected async Task HandleValidSubmit()
        {
            await AccountDataService.UpdatePaymentMethod(PaymentMethod);

            await OnPaymentMethodUpdated.InvokeAsync();
          //  PaymentMethod = null;
        }
        private async void Close()
        {
            PaymentMethod = null;
            await OnClose.InvokeAsync();
        }
    }
}

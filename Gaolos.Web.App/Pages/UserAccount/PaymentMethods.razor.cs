using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class PaymentMethods
    {
      
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        public IEnumerable<PaymentMethodViewModel> Cards { get; set; } 
            = new List<PaymentMethodViewModel>();

        private PaymentMethodViewModel? _selectedCard;


        protected override async Task OnInitializedAsync()
        {
            // Call the service to get the list of payment methods

            Cards = await AccountDataService.GetPaymentMethods();
            await base.OnInitializedAsync();
            
        }

        private  async Task DeletePaymentMethod(Guid cardId)
        {
            await AccountDataService.DeletePaymentMethod(cardId);
            await RefreshPaymentMethods();
        }
        private async Task RefreshPaymentMethods()
        {
            Cards = await AccountDataService.GetPaymentMethods();
        }
        private  void SelectCard( PaymentMethodViewModel card)
        {
            _selectedCard = card;
        }

        private void CloseModal()
        {
            _selectedCard = null;
        }

        public void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
    }
}

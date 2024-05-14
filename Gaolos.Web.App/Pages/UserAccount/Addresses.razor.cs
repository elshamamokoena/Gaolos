using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages.UserAccount
{
    public partial class Addresses
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ILoggedInUserService LoggedInUserService { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        public ICollection<DeliveryAddressViewModel> AddressesList { get; set; }
            = new List<DeliveryAddressViewModel>();

        private DeliveryAddressViewModel ?_selectedAddress;
        protected override async  Task OnInitializedAsync()
        {
            await GetAddresses();
           await base.OnInitializedAsync();
        }
        private async Task DeleteAddress(Guid addressId)
        {
            await AccountDataService.DeleteDeliveryAddress(addressId);
            await GetAddresses();
        }

        public async Task RefreshAddresses()
        {
            await GetAddresses();

        }

        public void Logout()
        {
            AuthenticationService.Logout();
            NavigationManager.NavigateTo("/", true);
        }
        private async Task GetAddresses()
        {
            AddressesList = (await AccountDataService.GetDeliveryAddresses()).ToList();
            StateHasChanged();

        }
        private void SelectAddress(DeliveryAddressViewModel address)
        {
            _selectedAddress = address;
        }
        private void ResetAddress()
        {
            _selectedAddress = null;
        }
    }
}

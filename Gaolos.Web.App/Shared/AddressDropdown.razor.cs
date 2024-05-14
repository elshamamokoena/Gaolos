using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Shared
{
    public partial class AddressDropdown
    {
        [Inject]
        public IAccountDataService AccountDataService { get; set; }
        private IEnumerable<DeliveryAddressViewModel> Addresses { get; set; }
        private DeliveryAddressViewModel _selectedAddress;

        protected override async Task OnInitializedAsync()
        {
            Addresses = await AccountDataService.GetDeliveryAddresses();
           _selectedAddress = await AccountDataService.GetPrimaryDeliveryAddress();
        }

        private async Task SetPrimaryAddress(DeliveryAddressViewModel address)
        {
            address.IsPrimary = true;
            await AccountDataService.UpdateDeliveryAddress(address);
            _selectedAddress = address;
        }


    }
}

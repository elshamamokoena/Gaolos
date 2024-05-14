using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class Checkout
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public IAccountDataService AccountDataService { get; set; }

        private PaymentMethodViewModel  _selectedCard { get; set; }
        public IEnumerable<PaymentMethodViewModel> PaymentMethods { get; set; }
            = new List<PaymentMethodViewModel>();
        public DeliveryAddressViewModel  Address { get; set; }

        [Inject]
        public ILoggedInUserService LoggedInUserService { get; set; }
        public LoggedInUserViewModel? LoggedInUser { get; set; }

        private CheckoutViewModel  Order { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _selectedCard = await AccountDataService.GetPrimaryPaymentMethod();
            PaymentMethods = await AccountDataService.GetPaymentMethods();
            Address = await AccountDataService.GetPrimaryDeliveryAddress();
            LoggedInUser = await LoggedInUserService.GetUserDetails();
            Order = await GetCheckoutData();

            await base.OnInitializedAsync();
        }

  

        private async Task PlaceOrder()
        {
          
            
         
            var response = await ShoppingBasketService.Checkout(Order);

            if (response.Success)
            {
                ApplicationState.NumberOfItems = 0;
                var orderId = response.Data.OrderId;
                NavigationManager.NavigateTo($"/order-confirmation/{orderId}");

            }else
            {
                NavigationManager.NavigateTo("/");

            }


        }

        private void SetPaymentMethod(PaymentMethodViewModel paymentMethod)
        {
            _selectedCard = paymentMethod;
        }

        private async Task<CheckoutViewModel> GetCheckoutData()
        {
            return new CheckoutViewModel
            {
                UserId = LoggedInUser.UserId,
                Address = Address.ToString(),
                Name = LoggedInUser.Name + " " + LoggedInUser.Surname,
                Phone = "+27679399796",
                Email = LoggedInUser.Email,
                ZipCode = Address.ZipCode,
                City = Address.City,

                CardName = _selectedCard.CardHolderName,
                CardNumber = _selectedCard.CardNumber,
                CardExpiration = _selectedCard.Expiry,
                CvvCode = _selectedCard.CVV

            };
        }

    }
}

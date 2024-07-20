using Blazored.LocalStorage;
using Fluxor;
using Gaolos.ComponentLibrary;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Store.CartState;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

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
            = new CheckoutViewModel();
        private bool _isReady = false;
        private bool _showDeliveryDetails = false;
        [Inject]
        public JsInterop jSRuntime { get; set; }
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }

        private bool _emptyBasket;
        [Inject]
        public IState<CartSummaryState> CartSummaryState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        protected override async Task OnInitializedAsync()
        {
            LoggedInUser = await LoggedInUserService.GetUserDetails();
            if (LoggedInUser != null)
            {
                _isReady = await FetchData();

            }
            else
            {
                _isReady = true;
            }
            _emptyBasket = CartSummaryState.Value.Basket == null || CartSummaryState.Value.Basket.NumberOfItems == 0;
            await base.OnInitializedAsync();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {


            await jSRuntime.FormatInput();


            await base.OnAfterRenderAsync(firstRender);
        }


        private async Task<bool> FetchData()
        {
            var tasks = new List<Task>();

        
            tasks.Add(Task.Run(async () =>
            {
                _selectedCard = await AccountDataService.GetPrimaryPaymentMethod();
            }));
            tasks.Add(Task.Run(async () =>
            {
                PaymentMethods = await AccountDataService.GetPaymentMethods();
            }));
            tasks.Add(Task.Run(async () =>
            {
                Address = await AccountDataService.GetPrimaryDeliveryAddress();
            }));


            _showDeliveryDetails = Address != null || _selectedCard!=null;

            var t = Task.WhenAll(tasks);
            try
            {
                await t.WaitAsync(CancellationToken.None);
            }catch 
            { }

            if (t.Status == TaskStatus.RanToCompletion)
            {
                return true;
            }
            if (t.Status == TaskStatus.Faulted)
            {
                return true;
            }
            return false;
      
        }

        private async Task PlaceOrder()
        {
            _isReady = false;
            if(Address != null)
            {
                Order.City = Address.City;
                Order.ZipCode = Address.ZipCode;
                Order.Address = Address.ToString();
            }
            var response = await ShoppingBasketService.Checkout(Order);

            if (response.Success)
            {
                ApplicationState.NumberOfItems = 0;
                var order = response.Data;
                NavigationManager.NavigateTo($"/order-confirmation?orderid={order.OrderId}&ordernumber={order.OrderNumber}",true);
            }else
            {
                Console.WriteLine("Errors: "+response.ValidationErrors);
                NavigationManager.NavigateTo("/");
            }
        }

        private void SetPaymentMethod(PaymentMethodViewModel paymentMethod)
        {
            _selectedCard = paymentMethod;
        }

   

    }
}

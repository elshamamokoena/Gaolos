using Blazored.LocalStorage;
using Fluxor;
using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Store.CartState;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class Order
    {
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
      
        [Inject]
        public IState<CounterState> CounterState { get; set; }
        [Inject]
        public IState<CartSummaryState> CartSummaryState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        public IEnumerable<BasketLineViewModel>  BasketLines { get; set; }
            = new List<BasketLineViewModel>();

        public BasketViewModel Basket { get; set; }
            = new BasketViewModel();

        //private string CouponCode { get; set; } 

        private CouponViewModel Coupon { get; set; } 
            = new CouponViewModel();

        private bool _emptyBasket;
        
        protected override async Task OnInitializedAsync()
        {
           await base.OnInitializedAsync();
        //    Dispatcher.Dispatch(new FetchDataAction());
           _emptyBasket = CartSummaryState.Value.Basket == null || CartSummaryState.Value.Basket.NumberOfItems == 0;

        }

        private async Task RemoveItemFromBasket(Guid basketLineId)
        {
            await ShoppingBasketService.RemoveItemFromBasket(CartSummaryState.Value.Basket.BasketId, basketLineId);
            Dispatcher.Dispatch(new FetchDataAction());
        }
   
        private async Task UpdateBasketLine(BasketLineViewModel basketLine)
        {
            if(basketLine.Quantity<1)
            {
                basketLine.Quantity = 1;
            }
            await ShoppingBasketService.UpdateBasketLine(CartSummaryState.Value.Basket.BasketId, basketLine.BasketLineId,basketLine.Quantity);
            Dispatcher.Dispatch(new FetchDataAction());


        }
    
        public async Task ApplyCoupon()
        {

            await ShoppingBasketService.ApplyCouponToBasket(CartSummaryState.Value.Basket.BasketId, Coupon.Code);
            Dispatcher.Dispatch(new FetchDataAction());
        }

        private async Task SwitchToCheckout()
        {
            NavigationManager.NavigateTo($"/cart?checkout=true");
           
        }
    }
}

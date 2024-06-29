using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class Order
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        public IEnumerable<BasketLineViewModel>  BasketLines { get; set; }
            = new List<BasketLineViewModel>();

        public BasketViewModel Basket { get; set; }
            = new BasketViewModel();

        //private string CouponCode { get; set; } 

        private CouponViewModel Coupon { get; set; } 
            = new CouponViewModel();

        
        protected override async Task OnInitializedAsync()
        {
            await GetBasket();
        
        }

        private async Task RemoveItemFromBasket(Guid basketLineId)
        {
            await ShoppingBasketService.RemoveItemFromBasket(ApplicationState.BasketId, basketLineId);
            await GetBasket();
        }
        private async Task UpdateBasketLine(BasketLineViewModel basketLine)
        {
            await ShoppingBasketService.UpdateBasketLine(ApplicationState.BasketId, basketLine.BasketLineId,basketLine.Quantity);
            await GetBasket();
        }
        private async Task GetBasket()
        {
            Basket = await ShoppingBasketService.GetBasket(ApplicationState.BasketId);
            BasketLines = await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId);
        }
        public async Task ApplyCoupon()
        {

            await ShoppingBasketService.ApplyCouponToBasket(ApplicationState.BasketId, Coupon.Code);
            await GetBasket();
        }   

        private async Task SwitchToCheckout()
        {
            NavigationManager.NavigateTo($"/cart?checkout=true");
           
        }
    }
}

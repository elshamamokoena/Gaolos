using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class CheckoutSummary
    {
         public BasketViewModel Basket { get; set; }
        = new BasketViewModel();
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Basket = await ShoppingBasketService.GetBasket(ApplicationState.BasketId);
            await base.OnInitializedAsync();
        }


    }
}

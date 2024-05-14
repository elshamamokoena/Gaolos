using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class Order
    {
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        public IEnumerable<BasketLineViewModel>  BasketLines { get; set; }
            = new List<BasketLineViewModel>();

        public BasketViewModel Basket { get; set; }
            = new BasketViewModel();

        protected override async Task OnInitializedAsync()
        {
            Basket = await ShoppingBasketService.GetBasket(ApplicationState.BasketId);
            BasketLines = await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId);
            await base.OnInitializedAsync();
        }
    }
}

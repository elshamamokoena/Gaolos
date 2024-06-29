using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class CartSummary
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        

        public BasketViewModel ?  Basket { get; set; }
        public IEnumerable<BasketLineViewModel> BasketLines { get; set; }
            = new List<BasketLineViewModel>();

        protected override async Task OnInitializedAsync()
        {
            var response = await ShoppingBasketService.CreateBasket();

            Basket = response.Success
                ? response.Data : new BasketViewModel();

            if(Basket is not null)
                ApplicationState.BasketId = Basket.BasketId;

            await base.OnInitializedAsync();
        }

        public async Task GetBasketLines()
        {
            Basket = await ShoppingBasketService.GetBasket(ApplicationState.BasketId);
            BasketLines = await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId);
            ApplicationState.NumberOfItems = BasketLines.Count();
            StateHasChanged();
        }
        public async Task RemoveItemFromBasket(Guid basketLineId)
        {
             await ShoppingBasketService.RemoveItemFromBasket(ApplicationState.BasketId, basketLineId);
             await GetBasketLines();
        }

        private void SwitchToCheckout()
        {
            NavigationManager.NavigateTo($"/cart?checkout=true");
        }

    }
}

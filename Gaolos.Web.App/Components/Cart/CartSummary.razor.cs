using Blazored.LocalStorage;
using Fluxor;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Store.CartState;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;
using System.Net.NetworkInformation;

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
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }

    
        [Inject]
        public IState<CartSummaryState> CartSummaryState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        public BasketViewModel ?  Basket { get; set; }
        public IEnumerable<BasketLineViewModel> BasketLines { get; set; }
            = new List<BasketLineViewModel>();

        protected override async Task OnInitializedAsync()
        {

            Dispatcher.Dispatch(new FetchDataAction());


            await base.OnInitializedAsync();

        }



        //public async Task GetBasketLines()
        //{
        //    Basket = await ShoppingBasketService.GetBasket(ApplicationState.BasketId);
        //    BasketLines = await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId);
        //    StateHasChanged();
        //}
        public async Task RemoveItemFromBasket(Guid basketLineId)
        {
            await ShoppingBasketService.RemoveItemFromBasket(CartSummaryState.Value.Basket.BasketId, basketLineId);
            Dispatcher.Dispatch(new FetchDataAction());

            //await GetBasketLines();

        }

        private void SwitchToCheckout()
        {
            NavigationManager.NavigateTo($"/cart?checkout=true");
        }

    }
}

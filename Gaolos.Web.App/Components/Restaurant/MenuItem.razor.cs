using Blazored.LocalStorage;
using Fluxor;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Store.CartState;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuItem
    {
        [Parameter]
        public MenuItemViewModel? Item { get; set; }

        [Parameter]
        public EventCallback<MenuItemViewModel> OnMenuItemSelected { get; set; }
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }
        [Inject]    
        private IStore Store { get; set; }
        [Inject]
        public IState<CounterState> CounterState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }
        private int _cartQuantity=0;

 
        protected override async Task OnParametersSetAsync()
        {
            await GetCartQuantity();

            await base.OnParametersSetAsync();
        }

        private async Task AddToCart(MenuItemViewModel menuItem)
        {
            var id= await LocalStorageService.GetItemAsync<Guid>("BasketId");
            var response = await ShoppingBasketService.AddItemToBasket(id, menuItem);

            if (response.Success)
            {
             //   var count = (await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId)).Count();
                await GetCartQuantity();
                Dispatcher.Dispatch(new FetchDataAction());

            }

        }
        private async Task GetCartQuantity()
        {
            var id = await LocalStorageService.GetItemAsync<Guid>("BasketId");
           _cartQuantity = await ShoppingBasketService.GetItemCount(id, Item.MenuItemId);
        }

    }
}

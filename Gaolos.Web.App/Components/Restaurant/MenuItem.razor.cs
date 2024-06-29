using Gaolos.Web.App.Contracts;
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
        
        private int _cartQuantity=0;

        //protected override async Task OnInitializedAsync()
        //{
        //    _cartQuantity = 0;
        //}
        protected override async Task OnParametersSetAsync()
        {
            await GetCartQuantity();

            await base.OnParametersSetAsync();
        }

        private async Task AddToCart(MenuItemViewModel menuItem)
        {

            var response = await ShoppingBasketService.AddItemToBasket(ApplicationState.BasketId, menuItem);

            if (response.Success)
            {
                ApplicationState.NumberOfItems = (await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId)).Count();
                await GetCartQuantity();
            }

        }
        private async Task GetCartQuantity()
        {
           _cartQuantity = await ShoppingBasketService.GetItemCount(ApplicationState.BasketId, Item.MenuItemId);
        }

    }
}

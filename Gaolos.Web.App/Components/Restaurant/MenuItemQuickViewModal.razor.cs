using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuItemQuickViewModal
    {
        [Parameter]
        public MenuItemViewModel? MenuItem { get; set; }
        private MenuItemViewModel? _menuItem;

        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        private int _cartQuantity = 0;
        private int _quantity = 1;
        protected override async Task OnParametersSetAsync()
        {
            _menuItem = MenuItem;
            _cartQuantity = await ShoppingBasketService.GetItemCount(ApplicationState.BasketId, _menuItem.MenuItemId);
        }

        private async Task AddToCart(MenuItemViewModel menuItem)
        {

            var response = await ShoppingBasketService.AddItemToBasket(ApplicationState.BasketId, menuItem, _quantity);

            if (response.Success)
            {
                ApplicationState.NumberOfItems = (await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId)).Count();
                await GetCartQuantity();
            }

        }
        private async Task GetCartQuantity()
        {
            _cartQuantity = await ShoppingBasketService.GetItemCount(ApplicationState.BasketId, _menuItem.MenuItemId);
        }
        public void Close()
        {
            _menuItem = null;
        }
    }
}

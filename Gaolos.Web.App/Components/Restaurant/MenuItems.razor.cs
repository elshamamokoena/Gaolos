using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuItems
    {
        [Parameter]

        public ICollection<MenuItemViewModel> MenuItemsList { get; set; } 
            = new List<MenuItemViewModel>();

        [Parameter]
        public EventCallback<MenuItemViewModel> OnMenuItemSelected { get; set; }

        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public ApplicationState ApplicationState { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private async Task AddToCart(MenuItemViewModel menuItem)
        {
   
           var response=  await ShoppingBasketService.AddItemToBasket(ApplicationState.BasketId, menuItem);
           
           if(response.Success)
            {
                ApplicationState.NumberOfItems = (await ShoppingBasketService.GetBasketLines(ApplicationState.BasketId)).Count();
            }

        }


     
    }
}

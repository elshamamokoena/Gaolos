using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuNavigation
    {
        [Parameter]
        public RestaurantViewModel Restaurant { get; set; }
        [Inject]
        public IMenuDataService MenuDataService { get; set; }

        public ICollection<MenuViewModel> Menus { get; set; }
        private MenuViewModel? _selectedMenu;

        [Parameter]
        public EventCallback<Guid> OnMenuSelected { get; set; }

        public ICollection<MenuItemViewModel> MenuItemsList { get; set; }
      = new List<MenuItemViewModel>();

        private MenuItemViewModel? _selectedMenuItem;


        //protected override async Task OnInitializedAsync()
        //{
        

        //}
        protected override async Task OnParametersSetAsync()
        {
            Menus = await MenuDataService.GetMenusForRestaurant(Restaurant.RestaurantId);
            await SelectMenu(Menus.FirstOrDefault());
            await base.OnParametersSetAsync();
        }
        private async Task SelectMenu(MenuViewModel menu)
        {
            _selectedMenu = menu;
            MenuItemsList = await MenuDataService.GetMenuItemsForMenu(menu.MenuId, Restaurant.RestaurantId);

            //  await OnMenuSelected.InvokeAsync(menu.MenuId);
        }
        public void ShowQuickViewPopup(MenuItemViewModel menuItem)
        {
            _selectedMenuItem = menuItem;
        }

     
    }
}

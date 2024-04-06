using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class Restaurant
    {
        [Parameter]
        public Guid RestaurantId { get; set; }

        public Guid MenuId { get; set; }

        [Inject]
        public IRestaurantDataService RestaurantDataService { get; set; }
        [Inject]
        public IMenuDataService MenuDataService { get; set; }

        public ICollection<MenuItemViewModel> MenuItemsList { get; set; }
            = new List<MenuItemViewModel>();

        public RestaurantViewModel RestaurantVm { get; set; }
        private MenuItemViewModel? _selectedMenuItem;
        protected override async Task OnInitializedAsync()
        {
           RestaurantVm = await RestaurantDataService.GetRestaurant(RestaurantId,null, null);

        }
        private async Task GetMenuItems(Guid menuId)
        {
            MenuItemsList = await MenuDataService.GetMenuItemsForMenu(menuId, RestaurantId);
        }
        public void ShowQuickViewPopup(MenuItemViewModel menuItem)
        {
            _selectedMenuItem = menuItem;
        }
    }
}

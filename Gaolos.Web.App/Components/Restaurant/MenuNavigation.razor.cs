using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuNavigation
    {
        [Parameter]
        public Guid RestaurantId { get; set; }
        [Inject]
        public IMenuDataService MenuDataService { get; set; }

        public ICollection<MenuViewModel> Menus { get; set; }

        [Parameter]
        public EventCallback<Guid> OnMenuSelected { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            Menus = await MenuDataService.GetMenusForRestaurant(RestaurantId);

        }
    }
}

using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Home
{
    public partial class PopularRestaurants
    {
        [Inject]
        public IRestaurantDataService restaurantDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public RestaurantListViewModel RestaurantList { get; set; } 
            = new RestaurantListViewModel();

        protected override async Task OnInitializedAsync()
        {
            RestaurantList = await restaurantDataService.GetRestaurants(null,null,12,1,null,null);
        }

        private void NavigateToRestaurant(Guid restaurantId)
        {

            NavigationManager.NavigateTo($"/restaurant/{restaurantId}");
        }

    }
}

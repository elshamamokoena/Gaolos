using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Shared
{
    public partial class Search
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IRestaurantDataService ? RestaurantDataService { get; set; }

        public ICollection<RestaurantViewModel> Restaurants { get; set; }
            = new List<RestaurantViewModel>(); 

        public string SearchTerm { get; set; } = string.Empty;
        private bool _hideModal = false;

        public async Task SearchForRestaurants()
        {
            Restaurants.Clear();

        

            if(RestaurantDataService is not null)
            {
                if(SearchTerm.Length > 2)
                {
                    var searchResults = await RestaurantDataService.GetRestaurants(SearchTerm, SearchTerm, 8, 1, null, null);
                    if (searchResults.Restaurants is not null)
                        Restaurants = searchResults.Restaurants;
                }
                   


            }
            if(SearchTerm == string.Empty)
            {
                Clear();
            }

        }
        private void Clear()
        {
            Restaurants.Clear();
        }
        private void NavigateToRestaurant(Guid restaurantId)
        {
            NavigationManager.NavigateTo($"/restaurant/{restaurantId}");
        }

    }
}

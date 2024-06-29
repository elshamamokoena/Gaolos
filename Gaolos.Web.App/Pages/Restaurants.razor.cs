using Gaolos.Web.App.Components;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class Restaurants
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
     

        [Inject]
        public IRestaurantDataService RestaurantDataService { get; set; }


        private int _restaurantCount;
        private int _pageSize = 12;
        private int _restaurantTotalCount;

        public PaginatedList<RestaurantViewModel> RestaurantList { get; set; }
            = new PaginatedList<RestaurantViewModel>();
        private ICollection<RestaurantViewModel> _restaurants { get; set; }
            = new List<RestaurantViewModel>();



        protected override async Task OnInitializedAsync()
        {
            await SearchForRestaurants();
        }

        protected override async Task OnParametersSetAsync()
        {
            _restaurants.Clear();
            await SearchForRestaurants();
        }

        private async Task SearchForRestaurants()
        {
            var restaurants = await RestaurantDataService.GetRestaurants("", null, _pageSize, 1, null, null);
            if (restaurants.Restaurants != null)
            {
                _restaurants = restaurants.Restaurants;
                _restaurantTotalCount = restaurants.TotalCount;
                RestaurantList
                    = new PaginatedList<RestaurantViewModel>(restaurants.Restaurants.ToList(), restaurants.TotalCount, restaurants.CurrentPage, restaurants.PageSize);

            }

            _restaurantCount = _restaurants.Count();

        }
        private async Task LoadMore()
        {
            var currentPage = RestaurantList.PageIndex + 1;
            var restaurants = await RestaurantDataService.GetRestaurants("", "", _pageSize, currentPage, null, null);
            RestaurantList = new PaginatedList<RestaurantViewModel>(restaurants.Restaurants.ToList(), restaurants.TotalCount, restaurants.CurrentPage, restaurants.PageSize);


            if (RestaurantList.Items != null)
            {
                _restaurants = _restaurants.Concat(RestaurantList.Items).ToList();
                _restaurantCount = _restaurants.Count();
            }
            StateHasChanged();
        }
        public void NavigateToRestaurant(Guid restaurantId)
        {
            NavigationManager.NavigateTo($"/restaurant/{restaurantId}");
        }
    }
}

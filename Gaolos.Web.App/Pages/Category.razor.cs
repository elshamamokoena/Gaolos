using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class Category
    {
        [Inject] 
        private NavigationManager NavigationManager { get; set; }
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public IRestaurantDataService RestaurantDataService { get; set; }

        [Parameter]
        public string ? CategoryId { get; set; }
        [Parameter]
        public string ? Name { get; set; }

        public RestaurantListViewModel RestaurantList { get; set; } 
        protected override async Task OnInitializedAsync()
        {
            var tag = Name.Split()[0];
            RestaurantList = await RestaurantDataService.GetRestaurants(tag,CategoryId,9,1,null,null);
        }
        public void NavigateToRestaurant(Guid restaurantId)
        {
            NavigationManager.NavigateTo($"/restaurant/{restaurantId}");
        }
    }
}

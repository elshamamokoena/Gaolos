using Gaolos.Web.App.Contracts;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Home
{
    public partial class PopularRestaurants
    {
        [Inject]
        public IRestaurantDataService ? RestaurantDataService { get; set; }

        public List<RestaurantDto> Restaurants { get; set; }


    }
}

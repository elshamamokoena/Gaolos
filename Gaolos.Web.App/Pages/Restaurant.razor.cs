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

        public RestaurantViewModel RestaurantVm { get; set; }
        protected override async Task OnParametersSetAsync()
        {
           RestaurantVm = await RestaurantDataService.GetRestaurant(RestaurantId,null, null);
        }
    
    
    }
}

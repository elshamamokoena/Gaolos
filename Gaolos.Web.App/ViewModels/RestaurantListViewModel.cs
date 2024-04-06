using Gaolos.Web.App.Pages;

namespace Gaolos.Web.App.ViewModels
{
    public class RestaurantListViewModel:ListViewModel
    {
        public ICollection<RestaurantViewModel>? Restaurants { get; set; }
    }
}

namespace Gaolos.Web.App.ViewModels
{
    public class CategoryRestaurantsViewModel
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<RestaurantNestedViewModel>? Restaurants { get; set; }
    }
}

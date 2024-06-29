namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class RestaurantListVm
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
    }
}
namespace Gaolos.Web.App.ViewModels
{
    public class RestaurantViewModel
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ? ImageUrl { get; set; }
        public string ? Tags { get; set; }
        public string ? LogoUrl { get; set; }
    }
}

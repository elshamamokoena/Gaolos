namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport
{
    public class RestaurantExportDto
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
      //  public DateTime Date { get; set; }
    }
}

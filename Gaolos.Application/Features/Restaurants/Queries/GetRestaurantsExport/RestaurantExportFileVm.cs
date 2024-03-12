namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport
{
    public class RestaurantExportFileVm
    {
        public string RestaurantExportFileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[]? Data { get; set; }
    }
}
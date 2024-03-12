using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using System.Collections.Generic;

namespace Gaolos.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportRestaurantsToCsv(List<RestaurantExportDto> restaurantExportDtos);
    }
}

using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport
{
    public class GetRestaurantsExportQuery: IRequest<RestaurantExportFileVm>
    {
    }
}

using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQuery : IRequest<List<RestaurantListVm>>
    {
    }
}

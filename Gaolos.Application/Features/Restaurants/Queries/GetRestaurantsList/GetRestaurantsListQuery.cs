using Gaolos.Application.Helpers;
using Gaolos.Application.ResourceParameters;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQuery : IRequest<IEnumerable<RestaurantListVm>>
    {
        public RestaurantResourceParameters ResourceParameters { get; set; }
    }
}

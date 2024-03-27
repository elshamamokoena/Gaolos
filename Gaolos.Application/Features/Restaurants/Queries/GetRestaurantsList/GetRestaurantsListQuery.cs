using Gaolos.Application.Helpers;
using Gaolos.Application.ResourceParameters;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQuery : IRequest<PagedListDto<RestaurantListVm>>
    {
        public RestaurantResourceParameters ResourceParameters { get; set; }
    }
}

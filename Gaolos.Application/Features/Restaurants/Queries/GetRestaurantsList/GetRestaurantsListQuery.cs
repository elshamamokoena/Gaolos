using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Restaurant;
using Gaolos.Application.ResourceParameters;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQuery : IRequest<PagedRestaurantsVm>
    {
      public RestaurantResourceParameters ResourceParameters { get; set; }
      public GetRestaurantsListQuery(RestaurantResourceParameters resourceParameters)
        {
            ResourceParameters = resourceParameters;
        }

    }
}

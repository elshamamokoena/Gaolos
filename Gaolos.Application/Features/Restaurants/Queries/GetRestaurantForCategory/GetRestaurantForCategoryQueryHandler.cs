using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantForCategory
{
    public class GetRestaurantForCategoryQueryHandler : IRequestHandler<GetRestaurantForCategoryQuery, RestaurantForCategoryDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public GetRestaurantForCategoryQueryHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<RestaurantForCategoryDto> Handle(GetRestaurantForCategoryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
          //  if(!await _restaurantRepository.)
        }
    }
}

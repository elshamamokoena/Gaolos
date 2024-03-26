using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQueryHandler : IRequestHandler<GetRestaurantsListQuery, IEnumerable<RestaurantListVm>>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsListQueryHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<IEnumerable<RestaurantListVm>> Handle(GetRestaurantsListQuery request, CancellationToken cancellationToken)
        {
            var allRestaurants = await _restaurantRepository.GetRestaurantsAsync(request.ResourceParameters);

            return _mapper.Map<IEnumerable<RestaurantListVm>>(allRestaurants);
        }
    }
}

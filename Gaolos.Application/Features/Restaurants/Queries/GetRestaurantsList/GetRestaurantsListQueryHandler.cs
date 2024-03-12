using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQueryHandler : IRequestHandler<GetRestaurantsListQuery, List<RestaurantListVm>>
    {
        private readonly IAsyncRepository<Restaurant> _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsListQueryHandler(IMapper mapper, IAsyncRepository<Restaurant> restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<List<RestaurantListVm>> Handle(GetRestaurantsListQuery request, CancellationToken cancellationToken)
        {
            var allRestaurants = (await _restaurantRepository.ListAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<RestaurantListVm>>(allRestaurants);
        }
    }
}

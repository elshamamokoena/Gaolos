using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Helpers;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQueryHandler : IRequestHandler<GetRestaurantsListQuery, PagedListDto<RestaurantListVm>>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsListQueryHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<PagedListDto<RestaurantListVm>> Handle(GetRestaurantsListQuery request, CancellationToken cancellationToken)
        {
            var allRestaurants = await _restaurantRepository.GetRestaurantsAsync(request.ResourceParameters);

            return _mapper.Map<PagedList<Restaurant>, PagedListDto<RestaurantListVm>>(allRestaurants);

          //  return _mapper.Map<PagedList<RestaurantListVm>>(allRestaurants);

            //var list = _mapper.Map<RestaurantListDto<RestaurantListVm>>(allRestaurants);

            //list.CurrentPage = allRestaurants.CurrentPage;
            //list.PageSize = allRestaurants.PageSize;
            //list.TotalCount = allRestaurants.TotalCount;
            //list.TotalPages = allRestaurants.TotalPages;
            //list.HasNext = allRestaurants.HasNext;
            //list.HasPrevious = allRestaurants.HasPrevious;
            //return list;
        }
    }
}

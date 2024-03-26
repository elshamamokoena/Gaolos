using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQueryHandler : IRequestHandler<GetRestaurantDetailQuery, RestaurantDetailVm>
    {
        private readonly IAsyncRepository<Restaurant> _restaurantRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetRestaurantDetailQueryHandler(
            IMapper mapper,
            IAsyncRepository<Restaurant> restaurantRepository,
            IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<RestaurantDetailVm> Handle(GetRestaurantDetailQuery request, CancellationToken cancellationToken)
        {
            //var @restaurant = await _restaurantRepository.GetByIdAsync(request.Id);
            //var restaurantDetailDto = _mapper.Map<RestaurantDetailVm>(@restaurant);

            //var category = await _categoryRepository.GetByIdAsync(@restaurant.CategoryId);

            //restaurantDetailDto.Category = _mapper.Map<CategoryDto>(category);

            //return restaurantDetailDto;
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Contracts.Services;
using Gaolos.Application.Exceptions;
using Gaolos.Application.Helpers;
using Gaolos.Domain.Entities;
using MediatR;
using System.Net.Http;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQueryHandler : IRequestHandler<GetRestaurantDetailQuery, RestaurantDetailVm>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyCheckerService _propertyCheckerService;
        

        public GetRestaurantDetailQueryHandler(
            IMapper mapper,
            IRestaurantRepository restaurantRepository,
            ICategoryRepository categoryRepository, IPropertyCheckerService propertyCheckerService)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _categoryRepository = categoryRepository;
            _propertyCheckerService = propertyCheckerService;
        }

        public async Task<RestaurantDetailVm> Handle(GetRestaurantDetailQuery request, CancellationToken cancellationToken)
        {

            //var @restaurant = await _restaurantRepository.GetByIdAsync(request.Id);
            //var restaurantDetailDto = _mapper.Map<RestaurantDetailVm>(@restaurant);

            //var category = await _categoryRepository.GetByIdAsync(@restaurant.CategoryId);

            //restaurantDetailDto.Category = _mapper.Map<CategoryDto>(category);

            //return restaurantDetailDto;
            // throw new NotImplementedException();


            if (!_propertyCheckerService.TypeHasProperties<RestaurantDetailVm>
         (request.Fields))
            {
                throw new BadRequestException($"Invalid field(s) requested: {request.Fields}");
                
                //return BadRequest(
                //  _problemDetailsFactory.CreateProblemDetails(HttpContext,
                //      statusCode: 400,
                //      detail: $"Not all requested data shaping fields exist on " +
                //      $"the resource: {fields}"));
            }

            var restaurant = await _restaurantRepository.GetRestaurantAsync(request.RestaurantId);
            if (restaurant == null) { throw new NotFoundException(nameof(Restaurant), request.RestaurantId);}

            return _mapper.Map<RestaurantDetailVm>(restaurant);


        }
    }
}

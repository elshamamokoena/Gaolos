using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Restaurant;
using Gaolos.Domain.Entities;
using MediatR;
using System.Net.Http;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class GetRestaurantsListQueryHandler : IRequestHandler<GetRestaurantsListQuery, PagedListDto<RestaurantDto>>
    {

        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyMappingService _propertyMappingService;

        public GetRestaurantsListQueryHandler(IMapper mapper, IRestaurantRepository restaurantRepository,
            IPropertyMappingService propertyMappingService)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _propertyMappingService = propertyMappingService;
        }

        public async Task<PagedListDto<RestaurantDto>> Handle(GetRestaurantsListQuery request, CancellationToken cancellationToken)
        {
            if(!_propertyMappingService.ValidMappingExistsFor<RestaurantDto, Restaurant>(request.ResourceParameters.OrderBy))
            {
                throw new BadRequestException($"Invalid orderby field: {request.ResourceParameters.OrderBy}");
            }

      //      if (!_propertyCheckerService.TypeHasProperties<AuthorDto>
      //(authorsResourceParameters.Fields))
      //      {
      //          return BadRequest(
      //              _problemDetailsFactory.CreateProblemDetails(HttpContext,
      //                  statusCode: 400,
      //                  detail: $"Not all requested data shaping fields exist on " +
      //                  $"the resource: {authorsResourceParameters.Fields}"));
      //      }

            var allRestaurants = await _restaurantRepository.GetRestaurantsAsync(request.ResourceParameters);

            return _mapper.Map<PagedList<Restaurant>, PagedListDto<RestaurantDto>>(allRestaurants);


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

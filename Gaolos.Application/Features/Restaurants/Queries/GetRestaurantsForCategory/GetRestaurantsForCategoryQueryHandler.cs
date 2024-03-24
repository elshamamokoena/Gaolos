using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory
{
    public class GetRestaurantsForCategoryQueryHandler : IRequestHandler<GetRestaurantsForCategoryQuery, IEnumerable<RestaurantsForCategoryDto>>
    {

        private readonly IRestaurantRepository _restaurantRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsForCategoryQueryHandler(IRestaurantRepository restaurantRepository, ICategoryRepository categoryRepository ,IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RestaurantsForCategoryDto>> Handle(GetRestaurantsForCategoryQuery request, CancellationToken cancellationToken)
        {
            if(! await _categoryRepository.CategoryExistsAsync(request.CategoryId))
            {
                throw new NotFoundException(nameof(Category), request.CategoryId);
            }
            var restaurantsForCategory = await _restaurantRepository.GetRestaurantsAsync(request.CategoryId);
            return _mapper.Map<IEnumerable<RestaurantsForCategoryDto>>(restaurantsForCategory);

        }
    }
}

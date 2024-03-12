using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants
{
    public class GetCategoriesListWithRestaurantsQueryHandler : IRequestHandler<GetCategoriesListWithRestaurantsQuery, List<CategoryRestaurantListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesListWithRestaurantsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryRestaurantListVm>> Handle(GetCategoriesListWithRestaurantsQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithRestaurants(request.IncludeHistory);
            return _mapper.Map<List<CategoryRestaurantListVm>>(list);
        }
    }
}

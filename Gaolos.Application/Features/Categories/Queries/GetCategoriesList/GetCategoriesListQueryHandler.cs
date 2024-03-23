using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, IEnumerable<CategoryListDto>>
    {
      //  private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));

            _categoryRepository = categoryRepository 
                ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public async Task<IEnumerable<CategoryListDto>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.GetCategoriesAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<CategoryListDto>>(allCategories);
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Helpers;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, PagedCategoriesVm>
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

        public async Task<PagedCategoriesVm> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = await _categoryRepository.GetCategoriesAsync(request.ResourceParameters);
            var categories = _mapper.Map<List<CategoryListVm>>(allCategories);
            return new PagedCategoriesVm{ 
                CurrentPage= allCategories.CurrentPage, 
                TotalPages = allCategories.TotalPages, 
                TotalCount = allCategories.TotalCount, 
                PageSize = allCategories.PageSize, 
                Categories = categories };
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Queries.GetPagedCategories
{
    public class GetPagedCategoriesQueryHandler : IRequestHandler<GetPagedCategoriesQuery, PagedCategoriesVm>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetPagedCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;   
        }
        public async Task<PagedCategoriesVm> Handle(GetPagedCategoriesQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetPagedCategories( request.Page, request.Size);
            var pagedCategories = _mapper.Map<List<PagedCategoryDto>>(list);

            var count = await _categoryRepository.GetTotalCountOfCategories();
            return new PagedCategoriesVm() { Count = count, PagedCategories = pagedCategories, Page = request.Page, Size = request.Size };
        }
    }
}

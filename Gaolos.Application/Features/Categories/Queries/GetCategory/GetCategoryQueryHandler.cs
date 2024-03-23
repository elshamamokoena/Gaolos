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

namespace Gaolos.Application.Features.Categories.Queries.GetCategory
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryDetailDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper ) 
        
        {
            _categoryRepository = categoryRepository 
                ?? throw new ArgumentNullException(nameof(categoryRepository));

            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));   
        }
        public async Task<CategoryDetailDto> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {

            var categoryFromRepo = await _categoryRepository.GetCategoryAsync(request.CategoryId);

            if ( categoryFromRepo == null )
            {
                throw new NotFoundException(nameof(Category), request.CategoryId );
            }

            return _mapper.Map<CategoryDetailDto>( categoryFromRepo );

        }
    }
}

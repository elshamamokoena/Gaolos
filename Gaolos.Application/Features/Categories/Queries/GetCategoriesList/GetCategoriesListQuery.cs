using Gaolos.Application.Helpers;
using Gaolos.Application.ResourceParameters;
using MediatR;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<PagedCategoriesVm>
    {
        public CategoryResourceParameters ResourceParameters { get; set; }
        public GetCategoriesListQuery(CategoryResourceParameters resourceParameters) 
        {
            ResourceParameters = resourceParameters;
        }
    }
}

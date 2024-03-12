using MediatR;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants
{
    public class GetCategoriesListWithRestaurantsQuery: IRequest<List<CategoryRestaurantListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}

using System;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants
{
    public class CategoryRestaurantDto
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}

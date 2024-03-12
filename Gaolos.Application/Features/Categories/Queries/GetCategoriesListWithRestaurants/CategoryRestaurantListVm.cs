using System;
using System.Collections.Generic;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants
{
    public class CategoryRestaurantListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryRestaurantDto> Restaurants { get; set; }
    }
}

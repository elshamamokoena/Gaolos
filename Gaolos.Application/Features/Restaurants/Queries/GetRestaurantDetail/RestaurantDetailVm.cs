using System;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class RestaurantDetailVm
    {
        public Guid RestaurantId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Guid CategoryId { get; set; }

        public CategoryDto Category { get; set; }
    }
}
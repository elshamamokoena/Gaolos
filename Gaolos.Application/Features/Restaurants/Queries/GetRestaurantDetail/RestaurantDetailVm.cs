using System;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class RestaurantDetailVm
    {
        public Guid RestaurantId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;


        //public Guid CategoryId { get; set; }

        //   public CategoryDto Category { get; set; }
    }
}
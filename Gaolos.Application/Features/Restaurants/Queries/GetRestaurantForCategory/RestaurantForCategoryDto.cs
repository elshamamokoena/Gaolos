using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantForCategory
{
    public class RestaurantForCategoryDto
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
    }
}

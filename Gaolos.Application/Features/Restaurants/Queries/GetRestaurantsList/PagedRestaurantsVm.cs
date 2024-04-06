using Gaolos.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList
{
    public class PagedRestaurantsVm:PagedResourceListVm
    {
        public ICollection<RestaurantListVm>? Restaurants { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory
{
    public class GetRestaurantsForCategoryQuery: IRequest<IEnumerable<RestaurantForCategoryDto>>
    {
        public Guid CategoryId { get; set; }
    }
}

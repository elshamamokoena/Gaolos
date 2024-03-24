using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantForCategory
{
    public class GetRestaurantForCategoryQuery: IRequest<RestaurantForCategoryDto>
    {
        public Guid CategoryId { get; set; }
        public Guid RestaurantId { get; set; }
    }
}

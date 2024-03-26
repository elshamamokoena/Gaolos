using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Menus.Queries.GetMenuForRestaurant
{
    public class GetMenuForRestaurantQuery:IRequest<MenuForRestaurantDto>
    {
        public Guid RestaurantId { get; set; }
        public Guid MenuId { get; set; }
    }
}

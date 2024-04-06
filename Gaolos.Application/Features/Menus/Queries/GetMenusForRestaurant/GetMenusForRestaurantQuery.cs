using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant
{
    public class GetMenusForRestaurantQuery: IRequest<IEnumerable<MenuForRestaurantVm>>
    {
        public Guid RestaurantId { get; set; }
    }
}

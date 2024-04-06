using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu
{
    public class GetMenuItemsForMenuQuery : IRequest<IEnumerable<MenuItemsForMenuVm>>
    {
        public Guid MenuId { get; set; }
    }
}

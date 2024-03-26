using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu
{
    public class GetMenuItemForMenuQuery:IRequest<MenuItemForMenuDto>
    {
        public Guid MenuId { get; set; }
        public Guid MenuItemId { get; set; }
    }
}

using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/restaurants/{restaurantId}/menus/{menuId}/menuitems")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MenuItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItemsForMenuDto>>> GetMenuItemsForMenu(Guid menuId)
        {
            var menuItems = await _mediator.Send(new GetMenuItemsForMenuQuery() { MenuId = menuId });
            return Ok(menuItems);
        }
        [HttpGet("{menuItemId}", Name = "GetMenuItemForMenu")]
        public async Task<ActionResult<MenuItemForMenuDto>> GetMenuItemForMenu(Guid menuId, Guid menuItemId)
        {
            var menuItem = await _mediator.Send(new GetMenuItemForMenuQuery() { MenuId = menuId, MenuItemId = menuItemId });
            return Ok(menuItem);
        }
    }
}

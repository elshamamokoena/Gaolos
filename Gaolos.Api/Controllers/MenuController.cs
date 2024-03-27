using Gaolos.Application.Features.Menus.Queries.GetMenuForRestaurant;
using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using Gaolos.Application.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [ApiController]
    [Route("api/restaurants/{restaurantId}/menus")]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MenuController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuForRestaurantDto>>> GetMenusForRestaurant(Guid restaurantId)
        {
            var menus = await _mediator.Send(new GetMenusForRestaurantQuery() { RestaurantId = restaurantId });
            return Ok(menus);
        }

        [HttpGet("{menuId}", Name ="GetMenuForRestaurant")]
        public async Task<IActionResult> GetMenuForRestaurant(Guid restaurantId, Guid menuId, string? fields)
        {
            var menu = await _mediator.Send(new GetMenuForRestaurantQuery() { RestaurantId = restaurantId, MenuId = menuId });
            return Ok(menu.ShapeData(fields));
        }

    }
}

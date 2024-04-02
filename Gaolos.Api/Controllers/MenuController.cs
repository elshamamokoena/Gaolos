using Gaolos.Application.Features.Menus.Queries.GetMenuForRestaurant;
using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models;
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

        [HttpGet(Name ="GetMenusForRestaurant")]
        public async Task<ActionResult<IEnumerable<MenuForRestaurantDto>>> GetMenusForRestaurant(Guid restaurantId)
        {
            var menus = await _mediator.Send(new GetMenusForRestaurantQuery() { RestaurantId = restaurantId });
            return Ok(menus);
        }

        [HttpGet("{menuId}", Name ="GetMenuForRestaurant")]
        public async Task<IActionResult> GetMenuForRestaurant(Guid restaurantId, Guid menuId, string? fields)
        {
            var menu = await _mediator.Send(new GetMenuForRestaurantQuery() { RestaurantId = restaurantId, MenuId = menuId });
            // create links
            var links = CreateLinksForMenu(restaurantId,menuId, fields);

            // add 
            //var linkedResourceToReturn = _mapper.Map<MenuForRestaurantDto>(menu)
            //    .ShapeData(fields) as IDictionary<string, object?>;
            var linkedResourceToReturn = menu.ShapeData(fields) as IDictionary<string, object?>;

            linkedResourceToReturn.Add("links", links);

            // return
            return Ok(linkedResourceToReturn);
            //return Ok(menu.ShapeData(fields));
        }
        private IEnumerable<LinkDto> CreateLinksForMenu(Guid restaurantId, Guid menuId,
    string? fields)
        {
            var links = new List<LinkDto>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                links.Add(
                  new(Url.Link("GetMenuForRestaurant", new { restaurantId , menuId}),
                  "self",
                  "GET"));
            }
            else
            {
                links.Add(
                  new(Url.Link("GetMenuForRestaurant", new { restaurantId,menuId, fields }),
                  "self",
                  "GET"));
            }

       

            return links;
        }

    }
}

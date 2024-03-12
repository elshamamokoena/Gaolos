using Gaolos.Api.Utility;
using Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.DeleteRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllRestaurants")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<RestaurantListVm>>> GetAllRestaurants()
        {
            var result = await _mediator.Send(new GetRestaurantsListQuery());
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetRestaurantById")]
        public async Task<ActionResult<RestaurantDetailVm>> GetRestaurantById(Guid id)
        {
            var getRestaurantDetailQuery = new GetRestaurantDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getRestaurantDetailQuery));
        }

        [HttpPost(Name = "AddRestaurant")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {
            var id = await _mediator.Send(createRestaurantCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateRestaurant")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateRestaurantCommand updateRestaurantCommand)
        {
            await _mediator.Send(updateRestaurantCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteRestaurant")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteEventCommand = new DeleteRestaurantCommand() { RestaurantId = id };
            await _mediator.Send(deleteEventCommand);
            return NoContent();
        }

        [HttpGet("export", Name = "ExportRestaurants")]
        [FileResultContentType("text/csv")]
        public async Task<FileResult> ExportEvents()
        {
            var fileDto = await _mediator.Send(new GetRestaurantsExportQuery());

            return File(fileDto.Data, fileDto.ContentType, fileDto.RestaurantExportFileName);
        }
    }
}

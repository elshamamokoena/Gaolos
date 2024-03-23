using Gaolos.Api.Utility;
using Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.DeleteRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList;
using Gaolos.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [ApiController]
    [Route("api/categories/{categoryId}/restaurants")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<IEnumerable<RestaurantForCategoryDto>>> GetRestaurantsForCategory(Guid categoryId)
        //{
        //    var dtos = await _mediator.Send(new GetRestaurantsForCategoryQuery { CategoryId = categoryId});  

        //    return Ok(dtos);
        //}
        //[HttpGet("{restaurantId}", Name = "GetRestaurantById")]
        //public async Task<ActionResult<RestaurantDetailVm>> GetRestaurantById(Guid id)
        //{
        //    var getRestaurantDetailQuery = new GetRestaurantDetailQuery() { Id = id };
        //    return Ok(await _mediator.Send(getRestaurantDetailQuery));
        //}



        //[HttpGet(Name = "GetAllRestaurants")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult<List<RestaurantListVm>>> GetAllRestaurants()
        //{
        //    var result = await _mediator.Send(new GetRestaurantsListQuery());
        //    return Ok(result);
        //}

        //[HttpGet("{id}", Name = "GetRestaurantById")]
        //public async Task<ActionResult<RestaurantDetailVm>> GetRestaurantById(Guid id)
        //{
        //    var getRestaurantDetailQuery = new GetRestaurantDetailQuery() { Id = id };
        //    return Ok(await _mediator.Send(getRestaurantDetailQuery));
        //}

        //[HttpPost(Name = "AddRestaurant")]
        //public async Task<ActionResult<Guid>> Create([FromBody] CreateRestaurantCommand createRestaurantCommand)
        //{
        //    var id = await _mediator.Send(createRestaurantCommand);
        //    return Ok(id);
        //}

        //[HttpPut(Name = "UpdateRestaurant")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> Update([FromBody] UpdateRestaurantCommand updateRestaurantCommand)
        //{
        //    await _mediator.Send(updateRestaurantCommand);
        //    return NoContent();
        //}

        //[HttpDelete("{id}", Name = "DeleteRestaurant")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    var deleteEventCommand = new DeleteRestaurantCommand() { RestaurantId = id };
        //    await _mediator.Send(deleteEventCommand);
        //    return NoContent();
        //}

        //[HttpGet("export", Name = "ExportRestaurants")]
        //[FileResultContentType("text/csv")]
        //public async Task<FileResult> ExportEvents()
        //{
        //    var fileDto = await _mediator.Send(new GetRestaurantsExportQuery());

        //    return File(fileDto.Data, fileDto.ContentType, fileDto.RestaurantExportFileName);
        //}
    }
}

using Gaolos.Api.ActionConstraints;
using Gaolos.Api.Helpers;
using Gaolos.Api.Utility;
using Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.DeleteRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text.Json;

namespace Gaolos.Api.Controllers
{
    [ApiController]
    [Route("api/restaurants")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantsController(IMediator mediator)
        {
            _mediator = mediator 
                ?? throw new ArgumentNullException(nameof(mediator));
        }

        [RequestHeaderMatchesMediaType("Accept",
    "application/json",
    "application/vnd.gaolos.restaurant.friendly+json")]
        [Produces("application/json",
    "application/vnd.gaolos.restaurant.friendly+json")]
        [HttpGet("{restaurantId}", Name = "GetRestaurant")]
        public async Task<IActionResult> GetRestaurantWithoutLinks(Guid restaurantId, string ? fields)
        {
            var restaurant = (await _mediator.Send(new GetRestaurantDetailQuery { RestaurantId = restaurantId, Fields= fields }))
                .ShapeData(fields);

            return Ok(restaurant);
        }

        [RequestHeaderMatchesMediaType("Accept",
         "application/vnd.gaolos.hateoas+json",
         "application/vnd.gaolos.restaurant.friendly.hateoas+json")]
        [Produces("application/vnd.gaolos.hateoas+json",
         "application/vnd.gaolos.restaurant.friendly.hateoas+json")]
        [HttpGet("{restaurantId}", Name ="GetRestaurantWithLinks")]

        public async Task<IActionResult> GetRestaurantWithLinks(Guid restaurantId, string ? fields)
        {
            var restaurant = await _mediator.Send(new GetRestaurantDetailQuery { RestaurantId = restaurantId, Fields = fields });

            var links = CreateLinksForRestaurant(restaurantId, fields);

            var linkedResourceToReturn = restaurant.ShapeData(fields)
                as IDictionary<string, object?>;

            linkedResourceToReturn.Add("links", links);

            return Ok(linkedResourceToReturn);
        }


        //[RequestHeaderMatchesMediaType("Accept",
        //    "application/vnd.gaolos.restaurant.full+json")]
        //[Produces("application/vnd.gaolos.restaurant.full+json")]
        //[HttpGet("{restaurantId}", Name = "GetRestaurant")]
        //public async Task<IActionResult> GetRestaurant(Guid restaurantId)
        //{
        //    var restaurant = await _mediator.Send(new GetRestaurantDetailQuery { RestaurantId = restaurantId });

        //    return Ok(restaurant);
        //}


        [HttpGet(Name ="GetRestaurants")]
        public async Task<IActionResult> GetRestaurants([FromQuery] RestaurantResourceParameters resourceParameters)
        {
            var result = await _mediator.Send(new GetRestaurantsListQuery(resourceParameters));

            //var previousPageLink = result.HasPrevious
            //    ? CreateRestaurantsResourceUri(resourceParameters, ResourceUriType.PreviousPage) : null;

            //var nextPageLink = result.HasNext
            //    ? CreateRestaurantsResourceUri(resourceParameters, ResourceUriType.NextPage) : null;

            var paginationMetadata = new
            {
                totalCount = result.TotalCount,
                pageSize = result.PageSize,
                currentPage = result.CurrentPage,
                totalPages = result.TotalPages,
                //previousPageLink = previousPageLink,
                //nextPageLink = nextPageLink
            };
            Response.Headers.Append("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));
            // create links
            var links = CreateLinksForRestaurants(resourceParameters,
                result.HasNext,
                result.HasPrevious);

            var restaurantsToReturn = result.Subset
                .ShapeData(resourceParameters.Fields);

            var shapedRestaurantsWithLinks = restaurantsToReturn.Select(restaurant =>
            {
                var restaurantAsDictionary = restaurant as IDictionary<string, object?>;
                var restaurantLinks = CreateLinksForRestaurant(
                    (Guid)restaurantAsDictionary["RestaurantId"],
                    null);
                restaurantAsDictionary.Add("links", restaurantLinks);
                return restaurantAsDictionary;
            });

            var linkedCollectionResource = new
            {
                value = shapedRestaurantsWithLinks,
                links = links
            };

            // return them
            return Ok(linkedCollectionResource);

         //   return Ok(restaurantsToReturn);
        }
        //[RequestHeaderMatchesMediaType("Accept", "application/json", "application/vnd.gaolos.hateoas+json")]
        //[Produces("application/json", "application/vnd.gaolos.restaurant.friendly+json")]
        //[HttpGet("{restaurantId}", Name = "GetRestaurant")]
        //public async Task<IActionResult> GetRestaurantWithoutLinks(Guid restaurantId , string ? fields)
        //{
        //    var restaurant = (await _mediator.Send(new GetRestaurantDetailQuery { RestaurantId = restaurantId })).ShapeData(fields);


        //    return Ok(restaurant);
        //}

        private string? CreateRestaurantsResourceUri(RestaurantResourceParameters resourceParameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetRestaurants",
                    new
                    {

                        fields = resourceParameters.Fields,
                        orderBy = resourceParameters.OrderBy,
                        pageNumber = resourceParameters.PageNumber - 1,
                        pageSize = resourceParameters.PageSize,
                        searchQuery = resourceParameters.SearchQuery,
                        tag = resourceParameters.Tag
                    });
                case ResourceUriType.NextPage:
                    return Url.Link("GetRestaurants",
                    new
                    {
                        fields = resourceParameters.Fields,
                        orderBy = resourceParameters.OrderBy,
                        pageNumber = resourceParameters.PageNumber + 1,
                        pageSize = resourceParameters.PageSize,
                        searchQuery = resourceParameters.SearchQuery,
                        tag = resourceParameters.Tag
                    });
                default:
                    return Url.Link("GetRestaurants",
                    new
                    {
                        fields = resourceParameters.Fields,
                        orderBy = resourceParameters.OrderBy,
                        pageNumber = resourceParameters.PageNumber,
                        pageSize = resourceParameters.PageSize,
                        searchQuery = resourceParameters.SearchQuery,
                        tag = resourceParameters.Tag
                    });
            }
        }

        private IEnumerable<LinkDto> CreateLinksForRestaurant(Guid restaurantId,
    string? fields)
        {
            var links = new List<LinkDto>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                links.Add(
                  new(Url.Link("GetRestaurant", new { restaurantId }),
                  "self",
                  "GET"));
            }
            else
            {
                links.Add(
                  new(Url.Link("GetRestaurant", new { restaurantId, fields }),
                  "self",
                  "GET"));
            }

            //links.Add(
            //      new(Url.Link("CreateCourseForAuthor", new { authorId }),
            //      "create_course_for_author",
            //      "POST"));
            links.Add(
                 new(Url.Link("GetMenusForRestaurant", new { restaurantId }),
                 "menus",
                 "GET"));

            return links;
        }

        private IEnumerable<LinkDto> CreateLinksForRestaurants(
     RestaurantResourceParameters restaurantResourceParameters,
     bool hasNext, bool hasPrevious)
        {
            var links = new List<LinkDto>();

            // self 
            links.Add(
                new(CreateRestaurantsResourceUri(restaurantResourceParameters,
                    ResourceUriType.Current),
                    "self",
                    "GET"));

            if (hasNext)
            {
                links.Add(
                    new(CreateRestaurantsResourceUri(restaurantResourceParameters,
                        ResourceUriType.NextPage),
                    "nextPage",
                    "GET"));
            }

            if (hasPrevious)
            {
                links.Add(
                    new(CreateRestaurantsResourceUri(restaurantResourceParameters,
                        ResourceUriType.PreviousPage),
                    "previousPage",
                    "GET"));
            }

            return links;
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

        [HttpPost(Name = "CreateRestaurant")]
        public async Task<ActionResult<Guid>> CreateRestaurant([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {
            var id = await _mediator.Send(createRestaurantCommand);
            return Ok(id);
        }

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

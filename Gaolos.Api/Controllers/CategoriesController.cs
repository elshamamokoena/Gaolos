using Gaolos.Api.ActionConstraints;
using Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesList;
//using Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants;
using Gaolos.Application.Features.Categories.Queries.GetCategory;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models;
using Gaolos.Application.ResourceParameters;


//using Gaolos.Application.Features.Categories.Queries.GetPagedCategories;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator 
                ?? throw new ArgumentNullException(nameof(mediator));
        }





        //[HttpGet("all", Name = "GetAllCategories")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        //{
        //    var dtos = await _mediator.Send(new GetCategoriesListQuery());
        //    return Ok(dtos);
        //}

        [HttpGet(Name ="GetCategories")]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult<PagedCategoriesVm>> GetCategories([FromQuery]CategoryResourceParameters resourceParameters )
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery(resourceParameters));
            return Ok(dtos);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [HttpGet("{categoryId}", Name = "GetCategory")]

        public async Task<ActionResult<CategoryDetailDto>> GetCategory(Guid categoryId)
        {
            var category = await _mediator.Send(new GetCategoryQuery { CategoryId = categoryId });


            return Ok(category);
        }

        //[HttpPost(Name = "CreateCategoryWithParent")]
        //[RequestHeaderMatchesMediaType("Content-Type",
        //               "application/vnd.gaolos.createcategorycommandwithparent+json")]
        //[Consumes(
        //    "application/vnd.gaolos.createcategorycommandwithparent+json")]
        //public async Task<IActionResult> CreateCategoryWithParent([FromBody] CreateCategoryWithParentCommand createCategoryCommand)
        //{
        //    var response = await _mediator.Send(createCategoryCommand);
        //    if (response.Success)
        //    {
        //        var links = CreateLinksForCategory(response.Category.CategoryId, response.Category.Name, null);
        //        var linkedResourceToReturn = response.Category
        //                                    .ShapeData(null) as IDictionary<string, object?>;
        //        linkedResourceToReturn.Add("links", links);
        //        return CreatedAtRoute("GetCategory", new { categoryId = linkedResourceToReturn["CategoryId"] }, linkedResourceToReturn);

        //    }
        //    return Ok(response);
        //}


        //[HttpPost(Name = "AddCategory")]
        //[RequestHeaderMatchesMediaType("Content-Type",
        //    "application/vnd.gaolos.createcategorycommand+json")]
        //[Consumes("application/json",
        //    "application/vnd.gaolos.createcategorycommand+json")]
        //public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand createCategoryCommand)
        //{
        //    var response = await _mediator.Send(createCategoryCommand);
           

        //    if (response.Success)
        //    {
        //        var links = CreateLinksForCategory(response.Category.CategoryId,response.Category.Name, null);
        //        var linkedResourceToReturn = response.Category
        //                                    .ShapeData(null) as IDictionary<string, object?>;
        //        linkedResourceToReturn.Add("links", links);
        //        return CreatedAtRoute("GetCategory", new { categoryId = linkedResourceToReturn["CategoryId"] }, linkedResourceToReturn);

        //    }

        //    return Ok(response);
        //}



        //[HttpOptions()]
        //public IActionResult GetCategoriesOptions()
        //{
        //    Response.Headers.Append("Allow", "GET,HEAD,POST,OPTIONS");
        //    return Ok();
        //}


//        private IEnumerable<LinkDto> CreateLinksForCategory(Guid categoryId, string? tag,
//string? fields)
//        {
//            var links = new List<LinkDto>();

//            if (string.IsNullOrWhiteSpace(fields))
//            {
//                links.Add(
//                  new(Url.Link("GetCategory", new { categoryId }),
//                  "self",
//                  "GET"));
//            }
//            else
//            {
//                links.Add(
//                  new(Url.Link("GetCategory", new { categoryId, fields }),
//                  "self",
//                  "GET"));
//            }
//            links.Add(
//             new(Url.Link("GetAllRestaurants", new { tag }),
//             "restaurants",
//             "GET"));


//            return links;
//        }
        //[HttpGet("/getpagedcategories", Name = "GetPagedCategories")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult<PagedCategoriesVm>> GetPagedCategories(int page, int size)
        //{
        //    var getPagedCategories = new GetPagedCategoriesQuery() { Page = page, Size = size };
        //    var dtos = await _mediator.Send(getPagedCategories);
        //    return Ok(dtos);
        //}

        //[HttpGet("allwithrestaurants", Name = "GetCategoriesWithRestaurants")]
        //[ProducesDefaultResponseType]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<List<CategoryRestaurantListVm>>> GetCategoriesWithRestaurants(bool includeHistory)
        //{
        //    GetCategoriesListWithRestaurantsQuery getCategoriesListWithEventsQuery = new GetCategoriesListWithRestaurantsQuery() { IncludeHistory = includeHistory };

        //    var dtos = await _mediator.Send(getCategoriesListWithEventsQuery);
        //    return Ok(dtos);
        //}

        //[HttpPost(Name = "AddCategory")]
        //public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        //{
        //    var response = await _mediator.Send(createCategoryCommand);
        //    return Ok(response);
        //}
    }
}

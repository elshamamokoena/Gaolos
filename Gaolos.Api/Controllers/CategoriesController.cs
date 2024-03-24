using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesList;
//using Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants;
using Gaolos.Application.Features.Categories.Queries.GetCategory;
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

        [HttpGet()]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<CategoryListDto>>> GetCategories()
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(dtos);
        }

        [HttpGet("{categoryId}", Name = "GetCategory")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
       // [ProducesDefaultResponseType]
        public async Task<ActionResult<CategoryDetailDto>> GetCategory(Guid categoryId)
        {
            var category = await _mediator.Send(new GetCategoryQuery { CategoryId = categoryId });
            return Ok(category);
        }


        [HttpPost(Name = "AddCategory")]
        public async Task<ActionResult<CreateCategoryCommandResponse>> CreateCategory([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);

            if(response.Success)
                return CreatedAtRoute("GetCategory",new { categoryId = response.Category.CategoryId }, response);

            return Ok(response);
        }

        [HttpOptions()]
        public IActionResult GetCategoriesOptions()
        {
            Response.Headers.Add("Allow", "GET,HEAD,POST,OPTIONS");
            return Ok();
        }

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

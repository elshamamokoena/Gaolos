using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesList;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(dtos);
        }

        [HttpGet("allwithrestaurants", Name = "GetCategoriesWithRestaurants")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryRestaurantListVm>>> GetCategoriesWithRestaurants(bool includeHistory)
        {
            GetCategoriesListWithRestaurantsQuery getCategoriesListWithEventsQuery = new GetCategoriesListWithRestaurantsQuery() { IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(getCategoriesListWithEventsQuery);
            return Ok(dtos);
        }

        [HttpPost(Name = "AddCategory")]
        public async Task<ActionResult<CreateCategoryCommandResponse>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}

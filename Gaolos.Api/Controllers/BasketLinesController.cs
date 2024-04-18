using Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Commands.DeleteBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/baskets/{basketId}/basketlines")]
    [ApiController]
    public class BasketLinesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BasketLinesController(IMediator mediator)
        {
            _mediator = mediator
                ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasketLinesVm>>> GetBasketLines(Guid basketId)
        {
            var basketLines= await _mediator.Send(new GetBasketLinesQuery { BasketId = basketId });

            return Ok(basketLines);
        }
        [HttpGet("{basketLineId}", Name ="GetBasketLine")]
        public async Task<ActionResult<BasketLineVm>> GetBasketLine(Guid basketId, Guid basketLineId)
        {
            var basketLine = await _mediator.Send(new GetBasketLineQuery { BasketId = basketId, BasketLineId = basketLineId });

            return Ok(basketLine);
        }
        [HttpPost]
        public async Task<ActionResult<CreateBasketLineCommandResponse>> AddBasketLine(Guid basketId,
            [FromBody] CreateBasketLineCommand addBasketLineCommand)
        {
            addBasketLineCommand.BasketId = basketId;
            var response = await _mediator.Send(addBasketLineCommand);

            if(response.Success)
            {
                return CreatedAtRoute("GetBasketLine", 
                                       new { basketId = basketId, basketLineId = response.BasketLine.BasketLineId }, response);
            }

            return Ok(response);
        }

        [HttpPut("{basketLineId}")]
        public async Task<ActionResult<UpdateBasketLineCommandResponse>> UpdateBasketLine(Guid basketId, Guid basketLineId,
                       [FromBody] BasketLineForUpdate basketLine)
        {
            var response = await _mediator.Send(new UpdateBasketLineCommand(basketLineId,basketId,basketLine.Quantity));

            return Ok(response);
        }
        [HttpDelete("{basketLineId}")]
        public async Task<IActionResult> DeleteBasketLine(Guid basketId, Guid basketLineId)
        {
            await _mediator.Send(new DeleteBasketLineCommand(basketLineId, basketId));

            return NoContent();
        }

    }
}

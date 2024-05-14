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

        [HttpGet(Name ="GetBasketLinesAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<BasketLinesVm>>> GetBasketLines(Guid basketId)
        {
            var basketLines= await _mediator.Send(new GetBasketLinesQuery { BasketId = basketId});

            return Ok(basketLines);
        }
        [HttpGet("{basketlineId}", Name ="GetBasketLineAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BasketLineVm>> GetBasketLine(Guid basketId, Guid basketlineId)
        {
            var basketLine = await _mediator.Send(new GetBasketLineQuery { BasketId= basketId, BasketLineId= basketlineId});

            return Ok(basketLine);
        }
        [HttpPost(Name ="AddBasketLineAsync")]
        public async Task<ActionResult<CreateBasketLineCommandResponse>> AddBasketLine(Guid basketId,
            [FromBody] BasketLineForCreationDto basketLine)
        {

            var response = await _mediator.Send(new CreateBasketLineCommand
            {
                BasketId = basketId,
                MenuItemId = basketLine.MenuItemId,
                Price = basketLine.Price,
                Quantity = basketLine.Quantity
            });

             //if(response.Success)
             //   return CreatedAtRoute("GetBasketLineAsync", 
             //       new { basketId, basketlineId = response.BasketLine.BasketLineId },
             //       response);

            return Ok(response);
        }

        [HttpPut("basketlineId", Name ="UpdateBasketlineAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateBasketLine(Guid basketId, Guid basketlineId,
            [FromBody] BasketLineForUpdateDto basketLine)
        {
            var response = await _mediator.Send(new UpdateBasketLineCommand
            {
                BasketId = basketId,
                BasketLineId = basketlineId,
                Quantity = basketLine.Quantity

            });

            return NoContent();
        }

        [HttpDelete("{basketlineId}", Name ="DeleteBasketlineAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteBasketLine(Guid basketId, Guid basketlineId)
        {
            await _mediator.Send(new DeleteBasketLineCommand 
                    { BasketId=basketId, 
                     BasketLineId= basketlineId
                    });

            return NoContent();
        }

    }
}

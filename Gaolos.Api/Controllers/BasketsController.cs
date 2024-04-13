using AutoMapper;
using Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasket;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/baskets")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BasketsController(IMediator mediator)
        {
            _mediator = mediator
                ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{basketId}", Name = "GetBasket")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BasketVm>> GetBasket(Guid basketId)
        {
            var basket = await _mediator.Send(new GetBasketQuery { BasketId = basketId });

            return Ok(basket);
        }

        [HttpPost(Name = "AddBasket")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CreateBasketCommandResponse>> AddBasket([FromBody] CreateBasketCommand addBasketCommand)
        {
            var response = await _mediator.Send(addBasketCommand);

            if(response.Success)
            {
                return CreatedAtRoute("GetBasket", 
                    new { basketId = response.Basket.BasketId }, response);
            }

            return response;
        }
    }
}

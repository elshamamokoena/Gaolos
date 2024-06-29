using AutoMapper;
using Gaolos.Application.Features.ShoppingBasket.Commands.ApplyCouponToBasket;
using Gaolos.Application.Features.ShoppingBasket.Commands.Checkout;
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

        [HttpGet("{basketId}", Name = "GetBasketAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BasketVm>> GetBasket(Guid basketId)
        {
            var basket = await _mediator.Send(new GetBasketQuery { BasketId = basketId });

            return Ok(basket);
        }

        [HttpPost(Name = "AddBasketAsync")]
        public async Task<ActionResult<CreateBasketCommandResponse>> AddBasket([FromBody] CreateBasketCommand addBasketCommand)
        {
            var response = await _mediator.Send(addBasketCommand);
            return Ok(response);
        }

        [HttpPut("{basketId}",Name ="ApplyCouponAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ApplyCoupon(Guid basketId, [FromBody] CouponDto coupon)
        {
            var response = await _mediator.Send(new ApplyCouponToBasketCommand 
            { BasketId=basketId,
            CouponId  = coupon.CouponId,
            CouponCode = coupon.Code
            });



            return Ok(response);
        }

        [HttpPost("CheckoutAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CheckoutCommandResponse>> Checkout([FromBody] CheckoutCommand checkoutCommand)
        {
            var response = await _mediator.Send(checkoutCommand);

            return Ok(response);
        }

    }
}

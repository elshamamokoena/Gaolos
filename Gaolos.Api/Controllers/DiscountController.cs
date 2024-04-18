using Gaolos.Application.Features.Discount.Commands.UseCouponCommand;
using Gaolos.Application.Features.Discount.Queries.GetCouponByCode;
using Gaolos.Application.Features.Discount.Queries.GetCouponById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DiscountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("code/{code}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDiscount(string code)
        {
            var coupon = await _mediator.Send(new GetCouponByCodeQuery { Code = code });
            return Ok(coupon);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDiscountById(Guid id)
        {
            var coupon = await _mediator.Send(new GetCouponByIdQuery { CouponId = id });
            return Ok(coupon);
        }
        [HttpPut(Name ="UseCoupon")]

        public async Task<IActionResult> UseCoupon([FromBody] UseCouponCommand useCouponCommand)
        {
           var response= await _mediator.Send(useCouponCommand);
            if (!response.Success)
                return Ok(response);

            return NoContent();
        }

    }
}

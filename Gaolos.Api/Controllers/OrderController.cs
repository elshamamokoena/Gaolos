using Gaolos.Application.Features.Orders.Queries.GetOrderForUser;
using Gaolos.Application.Features.Orders.Queries.GetOrdersForUser;
using Gaolos.Application.ResourceParameters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("api/account/{userId}/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetOrdersForUserAsync")]
        public async Task<ActionResult<PagedOrdersVm>> GetOrdersForUser(Guid userId, [FromQuery] OrderResourceParameters resourceParameters)
        {
            var dtos = await _mediator.Send(new GetOrdersForUserQuery { UserId = userId, OrderResourceParameters = resourceParameters });
            return Ok(dtos);
        }
        [HttpGet("{orderId}", Name = "GetOrderForUserAsync")]
        public async Task<ActionResult<DetailedOrderForUserVm>> GetOrderForUser(Guid userId, Guid orderId)
        {
            var dtos = await _mediator.Send(new GetOrderForUserQuery { UserId = userId, OrderId = orderId });
            return Ok(dtos);
        }
    }
}

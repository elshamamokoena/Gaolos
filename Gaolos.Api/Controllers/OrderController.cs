using Gaolos.Application.Features.Orders.Queries.GetOrdersForUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("user/{userId}", Name = "GetOrders")]
        public async Task<ActionResult<IEnumerable<OrderForUserVm>>> GetOrdersForUser(Guid userId)
        {
            var dtos = await _mediator.Send(new GetOrdersForUserQuery { UserId=userId});
            return Ok(dtos);
        }
        
    }
}

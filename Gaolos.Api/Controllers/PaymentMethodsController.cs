using AutoMapper;
using Gaolos.Application.Contracts;
using Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod;
using Gaolos.Application.Features.Account.Commands.PaymentMethods.DeletePaymentMethod;
using Gaolos.Application.Features.Account.Commands.PaymentMethods.UpdatePaymentMethod;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethods;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPrimaryMethod;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/account/{userId}/payments")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PaymentMethodsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet(Name ="GetPaymentMethodsAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CreditCardsVm>>> GetPaymentMethods(Guid userId)

        {
            var response = await _mediator.Send(new GetPaymentMethodsQuery { UserId=userId});
            return Ok(response);
        }


        [HttpGet("primary", Name ="GetPrimaryPaymentMethodAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<PaymentMethodVm>> GetPrimaryPaymentMethod(Guid userId)
        {
            var response = await _mediator.Send(new GetPrimaryMethodQuery { UserId=userId});
            return Ok(response);
        }


        [HttpGet("{creditcardId}", Name = "GetPaymentMethodAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaymentMethodVm>> GetPaymentMethod(Guid userId, Guid creditcardId)
        {
            var response = await _mediator.Send(new GetPaymentMethodQuery { UserId=userId, CreditCardId=creditcardId});
            return Ok(response);
        }

        [HttpPost(Name ="CreatePaymentMethodAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CreatePaymentMethodCommandResponse>> AddPaymentMethod(Guid userId, [FromBody] PaymentMethodForCreationDto paymentMethod)
        {
            var createPaymentMethodCommand = _mapper.Map<CreatePaymentMethodCommand>(paymentMethod);
            createPaymentMethodCommand.UserId = userId;

            var response =await _mediator.Send(createPaymentMethodCommand);
            return Ok(response);
        }
        [HttpDelete("{creditCardId}", Name ="DeletePaymentMethodAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeletePaymentMethod(Guid userId, Guid creditCardId)
        {
            await _mediator.Send(new DeletePaymentMethodCommand() { CreditCardId = creditCardId, UserId = userId });
            return NoContent();
        }
        [HttpPut("{creditcardId}", Name ="UpdatePaymentMethodAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdatePaymentMethod(Guid userId, Guid creditcardId, [FromBody]  PaymentMethodForUpdateDto paymentMethod)
        {
            var updatePaymentMethodCommand = _mapper.Map<UpdatePaymentMethodCommand>(paymentMethod);
            updatePaymentMethodCommand.UserId = userId;
            updatePaymentMethodCommand.CreditCardId = creditcardId;

            await _mediator.Send(updatePaymentMethodCommand);
            return NoContent();
        }
    }
}

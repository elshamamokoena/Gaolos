using AutoMapper;
using Gaolos.Application.Contracts;
using Gaolos.Application.Features.Account.Commands.Addresses.CreateAddress;
using Gaolos.Application.Features.Account.Commands.Addresses.DeleteAddress;
using Gaolos.Application.Features.Account.Commands.Addresses.UpdateAddress;
using Gaolos.Application.Features.Account.Queries.Addresses.GetAddress;
using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using Gaolos.Application.Features.Account.Queries.Addresses.GetPrimaryAddress;
using Gaolos.Application.ResourceParameters;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers
{
    [Route("api/account/{userId}/addresses")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public AddressController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator
                ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
           
        }

        [HttpGet(Name = "GetUserAddressesAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<UserAddressVm>>> GetAddresses(Guid userId)
        {
            var addresses = await _mediator.Send(new GetAddressesQuery { UserId =userId});
            return Ok(addresses);
        }

        [HttpGet("primary", Name = "GetPrimaryAddressAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<UserAddressVm>> GetPrimaryAddress(Guid userId)
        {
            var address = await _mediator.Send(new GetPrimaryAddressQuery { UserId = userId });

            return Ok(address);
        }


        [HttpGet("{addressId}", Name = "GetAddressAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<UserAddressVm>> GetAddress(Guid userId, Guid addressId, [FromQuery] AddressResourceParameters resourceParameters)
        {
            var address = await _mediator.Send(new GetAddressQuery { UserId= userId, 
                DeliveryAddressId=addressId});

            return Ok(address);
        }



        [HttpPost(Name ="CreateAddressAsync")]
        public async Task<ActionResult<CreateAddressCommandResponse>> CreateAddress(Guid userId,[FromBody] AddressForCreationDto address)
        {
            //create a command object
            var command =  _mapper.Map<CreateAddressCommand>(address);
            command.UserId = userId;

            //send the command to the mediator

            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut("{addressId}",Name = "UpdateAddressAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateAddress(Guid userId, Guid addressId, 
            [FromBody] AddressForUpdateDto addressForUpdate)
        {
            var command = _mapper.Map<UpdateAddressCommand>(addressForUpdate);
            command.UserId = userId;
            command.DeliveryAddressId = addressId;

            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{addressId}", Name = "DeleteAddressAsync")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteAddress(Guid userId, Guid addressId)
        {
            await _mediator.Send(new DeleteAddressCommand { UserId=userId, 
                DeliveryAddressId=addressId});

            return NoContent();
        }

    }
}

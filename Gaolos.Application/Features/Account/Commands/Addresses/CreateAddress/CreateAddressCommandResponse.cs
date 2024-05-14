using Gaolos.Application.Responses;

namespace Gaolos.Application.Features.Account.Commands.Addresses.CreateAddress
{
    public class CreateAddressCommandResponse:BaseResponse
    {
        public CreateAddressCommandResponse():base()
        {

        }
        public CreatedAddressVm Address { get; set; }
    }
}
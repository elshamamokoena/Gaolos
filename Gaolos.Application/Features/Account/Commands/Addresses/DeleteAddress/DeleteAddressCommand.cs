using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.Addresses.DeleteAddress
{
    public class DeleteAddressCommand:IRequest
    {
        public Guid DeliveryAddressId { get; set; }
        public Guid UserId { get; set; }
    }
}

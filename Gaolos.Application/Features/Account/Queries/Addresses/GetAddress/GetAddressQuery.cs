using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using Gaolos.Application.ResourceParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetAddress
{
    public class GetAddressQuery:IRequest<UserAddressVm>
    {
        public Guid DeliveryAddressId { get; set; }
        public Guid UserId { get; set; }

    }
}

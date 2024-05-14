using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetPrimaryAddress
{
    public class GetPrimaryAddressQuery:IRequest<UserAddressVm>
    {
        public Guid UserId { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses
{
    public class GetAddressesQuery:IRequest<IEnumerable<UserAddressVm>>
    {
        public Guid UserId { get; set; }
    }
}

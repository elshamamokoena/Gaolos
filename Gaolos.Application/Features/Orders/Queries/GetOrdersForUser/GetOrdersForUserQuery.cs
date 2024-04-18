using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrdersForUser
{
    public class GetOrdersForUserQuery : IRequest<IEnumerable<OrderForUserVm>>
    {
        public Guid UserId { get; set; }
    }
}

using Gaolos.Application.Features.Orders.Queries.GetOrdersForUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrderForUser
{
    public class GetOrderForUserQuery:IRequest<DetailedOrderForUserVm>
    {
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
    }
}

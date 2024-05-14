using Gaolos.Application.ResourceParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrdersForUser
{
    public class GetOrdersForUserQuery : IRequest<PagedOrdersVm>
    {
        public Guid UserId { get; set; }
        public OrderResourceParameters  OrderResourceParameters { get; set; }
    }
}

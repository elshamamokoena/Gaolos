using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrderAnonymously
{
    public class GetOrderAnonymouslyQuery:IRequest<AnonymousOrder>
    {
        public Guid OrderId { get; set; }
    }
}

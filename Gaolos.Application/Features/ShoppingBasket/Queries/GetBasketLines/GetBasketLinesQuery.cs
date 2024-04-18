using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines
{
    public class GetBasketLinesQuery: IRequest<IEnumerable<BasketLinesVm>>
    {
        public Guid BasketId { get; set; }
    }
}

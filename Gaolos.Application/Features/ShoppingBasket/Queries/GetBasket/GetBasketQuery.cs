using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasket
{
    public class GetBasketQuery: IRequest<BasketVm>
    {
        public Guid BasketId { get; set; }
    }
}

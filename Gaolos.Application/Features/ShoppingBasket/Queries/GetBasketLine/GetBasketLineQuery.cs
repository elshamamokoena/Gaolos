using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLine
{
    public class GetBasketLineQuery: IRequest<BasketLineVm>
    {
        public Guid BasketLineId { get; set; }
        public Guid BasketId { get; set; }
    }
}

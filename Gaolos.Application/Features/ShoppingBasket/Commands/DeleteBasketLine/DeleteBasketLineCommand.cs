using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.DeleteBasketLine
{
    public class DeleteBasketLineCommand:IRequest
    {
        public DeleteBasketLineCommand(Guid basketLineId, Guid basketId)
        {
            BasketLineId = basketLineId;
            BasketId = basketId;
        }
        public Guid BasketLineId { get; set; } = Guid.Empty;
        public Guid BasketId { get; set; } = Guid.Empty;
    }
}

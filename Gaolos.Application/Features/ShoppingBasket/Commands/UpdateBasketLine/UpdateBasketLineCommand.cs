using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine
{
    public class UpdateBasketLineCommand:IRequest<UpdateBasketLineCommandResponse>
    {
        //public UpdateBasketLineCommand(Guid basketLineId, Guid basketId, int quantity)
        //{
        //    BasketLineId = basketLineId;
        //    BasketId = basketId;
        //    Quantity = quantity;
        //}
        public Guid BasketLineId { get; set; } = Guid.Empty;
        public Guid BasketId { get; set; } = Guid.Empty;
        public int Quantity { get; set; }
    }
}

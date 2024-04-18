using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine
{
    public class CreateBasketLineCommand: IRequest<CreateBasketLineCommandResponse>
    {
        public Guid BasketId { get; set; }
        public Guid MenuItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

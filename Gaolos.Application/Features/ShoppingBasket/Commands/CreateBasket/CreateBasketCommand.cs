using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket
{
    public class CreateBasketCommand: IRequest<CreateBasketCommandResponse>
    {
        public Guid UserId { get; set; }

    }
}

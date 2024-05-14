using Gaolos.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine
{
    public class CreateBasketLineCommandResponse: BaseResponse
    {
        public CreateBasketLineCommandResponse(): base()
        {

        }

        public CreatedBasketLineVm BasketLine { get; set; }
    }
}

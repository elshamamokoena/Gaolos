using Gaolos.Application.Responses;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine
{
    public class UpdateBasketLineCommandResponse: BaseResponse
    {
        public UpdateBasketLineCommandResponse(): base()
        {
        }
        public UpdateBasketLineDto BasketLine { get; set; }
    }
    
}
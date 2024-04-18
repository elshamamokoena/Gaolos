using Gaolos.Application.Responses;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class CheckoutCommandResponse:BaseResponse
    {
        public CheckoutCommandResponse():base()
        {

        }

        public  OrderVm Order { get; set; }= default!;
    }
}
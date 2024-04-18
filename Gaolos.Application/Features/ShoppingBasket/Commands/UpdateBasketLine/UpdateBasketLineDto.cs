namespace Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine
{
    public class UpdateBasketLineDto
    {
        public Guid BasketLineId { get; set; }
        public Guid BasketId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
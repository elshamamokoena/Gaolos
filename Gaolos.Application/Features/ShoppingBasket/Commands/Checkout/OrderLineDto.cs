using Gaolos.Domain.Entities.ShoppingCart;
using Gaolos.Domain.Entities;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class OrderLineDto
    {
        public Guid OrderLineId { get; set; }
        public Guid MenuItemId { get; set; }
        //public MenuItem MenuItem { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
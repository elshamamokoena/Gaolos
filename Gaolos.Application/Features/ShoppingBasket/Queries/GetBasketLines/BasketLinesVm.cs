using Gaolos.Domain.Entities.ShoppingCart;
using Gaolos.Domain.Entities;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines
{
    public class BasketLinesVm
    {
        public Guid BasketLineId { get; set; }
        public Guid BasketId { get; set; }
        public Guid MenuItemId { get; set; }
        public MenuItemDto MenuItem { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
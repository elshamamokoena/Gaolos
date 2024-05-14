using Gaolos.Domain.Entities.ShoppingCart;
using Gaolos.Domain.Entities;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class OrderLineDto
    {
        public Guid OrderLineId { get; set; }
        public Guid MenuItemId { get; set; }
        public MenuItemsForMenuVm ? MenuItem { get; set; } 
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLine
{
    public class BasketLineVm
    {
        public Guid BasketLineId { get; set; }
        public Guid BasketId { get; set; }
        public Guid MenuItemId { get; set; }
        public MenuItemDto MenuItem { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

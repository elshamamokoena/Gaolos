using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.ShoppingCart
{
    public class BasketLine:AuditableEntity
    {
        public Guid BasketLineId { get; set; }
        public Guid BasketId { get; set; }
        public Basket Basket { get; set; } = null!;
        public Guid MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; } 
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}

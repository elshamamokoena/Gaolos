using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.ShoppingCart
{
    public class Basket
    {
        public Guid BasketId { get; set; }
        public Guid UserId { get; set; }
        public List<BasketLine> BasketLines { get; set; }
    }
}

using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.ShoppingCart
{
    public class Basket:AuditableEntity
    {
        public Guid BasketId { get; set; }
        public Guid ?UserId { get; set; }
        public ICollection<BasketLine> BasketLines { get; set; }
            =new List<BasketLine>();
        public Guid? CouponId { get; set; }
    }
}

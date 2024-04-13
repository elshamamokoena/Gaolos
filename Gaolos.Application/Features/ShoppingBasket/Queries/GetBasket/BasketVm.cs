using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasket
{
    public class BasketVm
    {
        public Guid BasketId { get; set; }
        public Guid UserId { get; set; }
        public int NumberOfItems { get; set; }
        public decimal BasketTotal { get; set; }
        public Guid? CouponId { get; set; }
    }
}

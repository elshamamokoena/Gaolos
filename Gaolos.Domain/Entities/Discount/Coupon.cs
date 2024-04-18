using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.Discount
{
    public class Coupon
    {
        public Guid CouponId { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; }
      //  public DateTime ExpiryDate { get; set; }
        public bool AlreadyUsed { get; set; }
    }
}

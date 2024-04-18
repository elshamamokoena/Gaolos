using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Models.Discount
{
    public class CouponVm
    {
        public Guid CouponId { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; }
        public bool AlreadyUsed { get; set; }
    }
}

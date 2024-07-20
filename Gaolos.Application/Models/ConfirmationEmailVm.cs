using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Models
{
    public class ConfirmationEmailVm
    {
        public Guid  OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderPlaced { get; set; } 
        public decimal OrderTotal { get; set; }
        public decimal? OrderDiscount { get; set; }
        public bool IsCouponApplied => OrderDiscount > 0;


    }
}

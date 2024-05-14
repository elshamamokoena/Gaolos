using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class OrderLine:AuditableEntity
    {
        public Guid OrderLineId { get; set; }
        public Guid OrderId { get; set; }
        public Guid MenuItemId { get; set; }
        
        public MenuItem ? MenuItem { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

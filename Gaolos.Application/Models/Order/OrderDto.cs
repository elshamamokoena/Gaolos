using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Models.Order
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderPlaced { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}

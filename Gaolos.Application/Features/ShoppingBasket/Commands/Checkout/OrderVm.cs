using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class OrderVm
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public int OrderTotal { get; set; }
        public string OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
        public ICollection<OrderLineDto> OrderLines { get; set; }
            = new List<OrderLineDto>();
        public string Comments { get; set; } = string.Empty;
    }
}

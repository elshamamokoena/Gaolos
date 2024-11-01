﻿using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrdersForUser
{
    public class OrderForUserVm
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public string OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
        public string  OrderStatus { get; set; } 
    }
}

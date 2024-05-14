using Gaolos.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrdersForUser
{
    public class PagedOrdersVm:PagedResourceListVm
    {
        public ICollection<OrderForUserVm>? Orders { get; set; }
    }
}

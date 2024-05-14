using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public enum OrderStatus
    {   
        Pending,
        Processing,
        Collected,
        Delivered,
        Cancelled
    }
}

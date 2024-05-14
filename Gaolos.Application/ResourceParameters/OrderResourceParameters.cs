using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.ResourceParameters
{
    public class OrderResourceParameters:BaseResourceParameters
    {
        public string OrderBy { get; set; } = "";
        public OrderStatus ? OrderStatus { get; set; } 
    }
}

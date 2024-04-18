using Gaolos.Application.Models.Discount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Queries.GetCouponByCode
{
    public class GetCouponByCodeQuery:IRequest<CouponVm>
    {
        public string Code { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Commands.UseCouponCommand
{
    public class UseCouponCommand:IRequest<UseCouponCommandResponse>
    {
        public Guid CouponId { get; set; }
    }
}

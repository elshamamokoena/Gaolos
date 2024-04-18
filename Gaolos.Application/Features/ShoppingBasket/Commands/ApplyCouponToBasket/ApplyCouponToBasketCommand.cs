using Gaolos.Domain.Entities.Discount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.ApplyCouponToBasket
{
    public class ApplyCouponToBasketCommand:IRequest<ApplyCouponToBasketCommandResponse>
    {
        public Guid BasketId { get; set; }
        public Coupon Coupon { get; set; }
    }
}

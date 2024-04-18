using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.ApplyCouponToBasket
{
    public class ApplyCouponToBasketCommandValidator:AbstractValidator<ApplyCouponToBasketCommand>
    {
        public ApplyCouponToBasketCommandValidator()
        {
            RuleFor(p => p.BasketId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .NotEqual(Guid.Empty).WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Coupon)
                //.NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull().WithMessage("Coupon cannot be null");
        }
    }
}

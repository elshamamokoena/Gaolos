using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Commands.UseCouponCommand
{
    public class UseCouponCommandValidator:AbstractValidator<UseCouponCommand>
    {
        public UseCouponCommandValidator()
        {
            RuleFor(p => p.CouponId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .NotEqual(Guid.Empty).WithMessage("{PropertyName} is required.");
        }
    }
}

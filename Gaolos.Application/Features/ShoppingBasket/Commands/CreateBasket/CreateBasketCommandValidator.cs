using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket
{
    public class CreateBasketCommandValidator: AbstractValidator<CreateBasketCommand>
    {
        public CreateBasketCommandValidator()
        {
            RuleFor(p => p.UserId)
                .NotEmpty().WithMessage("{UserId} is required.")
                .NotNull();
        }
    }
}

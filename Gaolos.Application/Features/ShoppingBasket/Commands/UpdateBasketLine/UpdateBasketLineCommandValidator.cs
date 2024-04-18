using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine
{
    public class UpdateBasketLineCommandValidator: AbstractValidator<UpdateBasketLineCommand>
    {
        public UpdateBasketLineCommandValidator()
        {
            RuleFor(p => p.BasketLineId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.BasketId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            //RuleFor(p => p.MenuItemId)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull();

            //RuleFor(p => p.Price)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .GreaterThan(0);

            RuleFor(p => p.Quantity)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0);
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class CheckoutCommandValidator:AbstractValidator<CheckoutCommand>
    {
        public CheckoutCommandValidator()
        {
            RuleFor(p => p.BasketId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            //RuleFor(p => p.UserId)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull();
            
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
          RuleFor(p=>p.Email)
                .EmailAddress()
                .WithMessage("{PropertyName} is not a valid email address.")
                .NotEmpty().WithMessage("Email is required");
            RuleFor(p => p.ZipCode)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(p => p.City)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

    
        }
    }
}

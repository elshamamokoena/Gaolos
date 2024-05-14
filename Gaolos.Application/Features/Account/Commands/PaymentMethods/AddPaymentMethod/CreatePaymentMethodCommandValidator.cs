using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod
{
    public class CreatePaymentMethodCommandValidator:AbstractValidator<CreatePaymentMethodCommand>
    {
        public CreatePaymentMethodCommandValidator()
        {
            RuleFor(p => p.UserId)
                .NotEmpty().WithMessage("User is not logged in.")
                .NotNull();

            RuleFor(p => p.CardNumber)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Expiry)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.CVV)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.CardHolderName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }

    }
}

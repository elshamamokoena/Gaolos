using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.DeletePaymentMethod
{
    public class DeletePaymentMethodCommandHandler : IRequestHandler<DeletePaymentMethodCommand>
    {
        private readonly ICreditCardRepository _creditCardRepository;
        public DeletePaymentMethodCommandHandler(ICreditCardRepository creditCardRepository)
        {
            _creditCardRepository = creditCardRepository 
                ?? throw new ArgumentNullException(nameof(creditCardRepository));
        }
        public async Task Handle(DeletePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var creditCardToDelete = await _creditCardRepository.GetCreditCardAsync(request.UserId, request.CreditCardId);

            if (creditCardToDelete == null) throw new NotFoundException(nameof(creditCardToDelete), request.CreditCardId);

            _creditCardRepository.DeleteCreditCard(creditCardToDelete);
            await _creditCardRepository.SaveAsync();
        }
    }
}

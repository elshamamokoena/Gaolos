using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.UpdatePaymentMethod
{
    public class UpdatePaymentMethodCommandHandler : IRequestHandler<UpdatePaymentMethodCommand>
    {
        private readonly ICreditCardRepository _creditCardRepository;
        private readonly IMapper _mapper;
        public UpdatePaymentMethodCommandHandler(ICreditCardRepository creditCardRepository, IMapper mapper)
        {
            _creditCardRepository = creditCardRepository 
                ?? throw new ArgumentNullException(nameof(creditCardRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task Handle(UpdatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var creditCardToUpdate = await _creditCardRepository.GetCreditCardAsync(request.UserId, request.CreditCardId);
            if (creditCardToUpdate == null) throw new NotFoundException(nameof(creditCardToUpdate), request.CreditCardId);

            _mapper.Map(request, creditCardToUpdate);
            _creditCardRepository.UpdateCreditCard(creditCardToUpdate);
            await _creditCardRepository.SaveAsync();
        }
    }
}

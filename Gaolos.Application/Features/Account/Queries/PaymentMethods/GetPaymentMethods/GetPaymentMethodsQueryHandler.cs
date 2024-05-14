using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethods
{
    
    public class GetPaymentMethodsQueryHandler : IRequestHandler<GetPaymentMethodsQuery, IEnumerable<CreditCardsVm>>
    {
        private readonly ICreditCardRepository _creditCardRepository;
        private readonly IMapper _mapper;

        public GetPaymentMethodsQueryHandler(ICreditCardRepository creditCardRepository, IMapper mapper)
        {
            _creditCardRepository = creditCardRepository
                ?? throw new ArgumentNullException(nameof(creditCardRepository));
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<CreditCardsVm>> Handle(GetPaymentMethodsQuery request, CancellationToken cancellationToken)
        {
            var creditCards = await _creditCardRepository.GetCreditCardsForUserAsync(request.UserId);
            return _mapper.Map<IEnumerable<CreditCardsVm>>(creditCards);
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod
{
    public class GetPaymentMethodQueryHandler : IRequestHandler<GetPaymentMethodQuery, PaymentMethodVm>
    {
        private readonly ICreditCardRepository _creditCardRepository;
        private readonly IMapper _mapper;
        public GetPaymentMethodQueryHandler(ICreditCardRepository creditCardRepository, IMapper mapper)
        {
            _creditCardRepository = creditCardRepository 
                ?? throw new ArgumentNullException(nameof(creditCardRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<PaymentMethodVm> Handle(GetPaymentMethodQuery request, CancellationToken cancellationToken)
        {
            if(request.UserId == Guid.Empty) throw new BadRequestException($" User id ({request.UserId}) is empty");
            if(request.CreditCardId == Guid.Empty) throw new BadRequestException($" Credit card id ({request.CreditCardId}) is empty");
            var paymentMethod =await  _creditCardRepository.GetCreditCardAsync(request.UserId, request.CreditCardId);
            if(paymentMethod == null) throw new NotFoundException(nameof(paymentMethod), request.CreditCardId);

            return  _mapper.Map<PaymentMethodVm>(paymentMethod);
        }
    }
}

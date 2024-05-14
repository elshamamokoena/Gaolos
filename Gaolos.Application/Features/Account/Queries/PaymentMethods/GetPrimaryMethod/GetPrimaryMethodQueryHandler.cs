using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPrimaryMethod
{
    public class GetPrimaryMethodQueryHandler : IRequestHandler<GetPrimaryMethodQuery, PaymentMethodVm>
    {
        private readonly ICreditCardRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public GetPrimaryMethodQueryHandler(ICreditCardRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository 
                ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<PaymentMethodVm> Handle(GetPrimaryMethodQuery request, CancellationToken cancellationToken)
        {
            var paymentMethod = await _paymentMethodRepository.GetPrimaryCreditCardAsync(request.UserId);
            return _mapper.Map<PaymentMethodVm>(paymentMethod);

        }
    }
}

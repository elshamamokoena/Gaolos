using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities.UserAccount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod
{
    public class CreatePaymentMethodCommandHandler:IRequestHandler<CreatePaymentMethodCommand, CreatePaymentMethodCommandResponse>
    {
        private readonly ICreditCardRepository _paymentMethodRepository;
        private readonly IMapper _mapper;
        public CreatePaymentMethodCommandHandler(ICreditCardRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository ?? throw new ArgumentNullException(nameof(paymentMethodRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreatePaymentMethodCommandResponse> Handle(CreatePaymentMethodCommand request, CancellationToken cancellationToken)
        {
            var response = new CreatePaymentMethodCommandResponse();
            var validator = new CreatePaymentMethodCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (response.Success)
            {
                 var creditCard = _mapper.Map<CreditCard>(request);
                 _paymentMethodRepository.AddCreditCard(creditCard);
                 await _paymentMethodRepository.SaveAsync();
                 response.PaymentMethod = _mapper.Map<CreatedPaymentMethodVm>(creditCard);
            }
      
            return response;
        }
    
    }
  
}

using AutoMapper;
using Gaolos.Application.Contracts;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities.ShoppingCart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket
{
    public class CreateBasketCommandHandler : IRequestHandler<CreateBasketCommand, CreateBasketCommandResponse>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;

        public CreateBasketCommandHandler(IBasketRepository basketRepository, IMapper mapper, ILoggedInUserService loggedInUserService)
        {
            _basketRepository = basketRepository
                ?? throw new ArgumentNullException(nameof(basketRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
            _loggedInUserService = loggedInUserService 
                ?? throw new ArgumentNullException(nameof(loggedInUserService));
        }
        public async Task<CreateBasketCommandResponse> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
        {

            var createBasketCommandResponse = new CreateBasketCommandResponse();
            var validator = new CreateBasketCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                createBasketCommandResponse.Success = false;
                createBasketCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createBasketCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createBasketCommandResponse.Success)
            {
                var basket = _mapper.Map<Basket>(request);

              
                _basketRepository.AddBasket(basket);

                await _basketRepository.SaveAsync();
                createBasketCommandResponse.Basket = _mapper.Map<CreatedBasketVm>(basket);
            }
            return createBasketCommandResponse;
        }
    }
}

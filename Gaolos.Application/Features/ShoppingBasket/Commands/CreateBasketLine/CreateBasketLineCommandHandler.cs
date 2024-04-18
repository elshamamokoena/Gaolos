using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Domain.Entities.ShoppingCart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine
{
    public class CreateBasketLineCommandHandler : IRequestHandler<CreateBasketLineCommand, CreateBasketLineCommandResponse>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IBasketLineRepository _basketLineRepository;
        private IMenuItemsRepository _menuItemsRepository;
        private readonly IMapper _mapper;

        public CreateBasketLineCommandHandler(IBasketRepository shoppingBasketRepository,
            IBasketLineRepository basketLineRepository, IMapper mapper, IMenuItemsRepository menuItemsRepository)
        {
            _shoppingBasketRepository = shoppingBasketRepository 
                ?? throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _basketLineRepository = basketLineRepository 
                ?? throw new ArgumentNullException(nameof(basketLineRepository));
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
            _menuItemsRepository = menuItemsRepository 
                ?? throw new ArgumentNullException(nameof(menuItemsRepository));
        }


        public async Task<CreateBasketLineCommandResponse> Handle(CreateBasketLineCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateBasketLineCommandResponse();
            var validator = new CreateBasketLineCommandValidator();
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
            var basket = await _shoppingBasketRepository.GetBasketAsync(request.BasketId);

            if(basket == null)
            {
                throw new NotFoundException(nameof(Basket), request.BasketId);
            }

            //if(! await _menuItemsRepository.MenuItemExists(request.MenuItemId))
            //{
                 //implement later
            //}

            var basketLine = _mapper.Map<BasketLine>(request);
            var processedBasketLine = await _basketLineRepository.AddOrUpdateBasketLine(request.BasketId,basketLine);
            await _basketLineRepository.SaveAsync();

            response.BasketLine = _mapper.Map<CreateBasketLineDto>(processedBasketLine);
            return response;
        }
    }
}

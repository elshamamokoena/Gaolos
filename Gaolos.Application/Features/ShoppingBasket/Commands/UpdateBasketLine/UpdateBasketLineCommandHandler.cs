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

namespace Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine
{
    public class UpdateBasketLineCommandHandler : IRequestHandler<UpdateBasketLineCommand, UpdateBasketLineCommandResponse>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IBasketLineRepository _basketLineRepository;
        private readonly IMapper _mapper;
        public UpdateBasketLineCommandHandler(IBasketRepository shoppingBasketRepository, 
            IMapper mapper,
            IBasketLineRepository basketLineRepository)
        {
            _shoppingBasketRepository = shoppingBasketRepository
                ?? throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
            _basketLineRepository = basketLineRepository 
                ?? throw new ArgumentNullException(nameof(basketLineRepository));
        }
        public async Task<UpdateBasketLineCommandResponse> Handle(UpdateBasketLineCommand request, CancellationToken cancellationToken)
        {

            var response = new UpdateBasketLineCommandResponse();
            var validator = new UpdateBasketLineCommandValidator();
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



            if (!await _shoppingBasketRepository.BasketExistsAsync(request.BasketId))
            {
                throw new NotFoundException(nameof(Basket), request.BasketId);
            }
            var basketLine = await _basketLineRepository.GetBasketLineAsync(request.BasketLineId);
            if (basketLine == null)
            {
                throw new NotFoundException(nameof(BasketLine), request.BasketLineId);
            }
            _mapper.Map(request, basketLine);
            _basketLineRepository.UpdateBasketLine(basketLine);
            await _basketLineRepository.SaveAsync();
            response.BasketLine = _mapper.Map<UpdateBasketLineDto>(basketLine) ;
            return response;

        }
    }
}

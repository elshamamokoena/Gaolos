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

namespace Gaolos.Application.Features.ShoppingBasket.Commands.DeleteBasketLine
{
    public class DeleteBasketLineCommandHandler : IRequestHandler<DeleteBasketLineCommand>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IBasketLineRepository _basketLineRepository;
        private readonly IMapper _mapper;
        public DeleteBasketLineCommandHandler(IBasketRepository shoppingBasketRepository,
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
        public async Task Handle(DeleteBasketLineCommand request, CancellationToken cancellationToken)
        {
            var basket = await _shoppingBasketRepository.GetBasketAsync(request.BasketId);
            if(basket==null)
            {
                throw new NotFoundException(nameof(Basket), request.BasketId);
            }
            var basketLine = await _basketLineRepository.GetBasketLineAsync(request.BasketLineId);
            if(basketLine==null)
            {
                throw new NotFoundException(nameof(BasketLine), request.BasketLineId);
            }
             _basketLineRepository.RemoveBasketLine(basketLine);
            await _basketLineRepository.SaveAsync();
        }
    }

}

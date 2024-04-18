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

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLine
{
    public class GetBasketLineQueryHandler : IRequestHandler<GetBasketLineQuery, BasketLineVm>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IBasketLineRepository _basketLineRepository;
        private readonly IMapper _mapper;
        public GetBasketLineQueryHandler(IBasketRepository shoppingBasketRepository, 
                       IBasketLineRepository basketLineRepository, IMapper mapper)
        {
            _shoppingBasketRepository = shoppingBasketRepository ?? 
                throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _basketLineRepository = basketLineRepository?? 
                throw new ArgumentNullException(nameof(basketLineRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BasketLineVm> Handle(GetBasketLineQuery request, CancellationToken cancellationToken)
        {
            if(!await _shoppingBasketRepository.BasketExistsAsync(request.BasketId))
            {
                throw new NotFoundException(nameof(Basket), request.BasketId);
            }

            var basketLine = await _basketLineRepository.GetBasketLineAsync(request.BasketLineId);

            if(basketLine == null)
            {
                throw new NotFoundException(nameof(BasketLine), request.BasketLineId);
            }
            return _mapper.Map<BasketLineVm>(basketLine);

        }
    }
}

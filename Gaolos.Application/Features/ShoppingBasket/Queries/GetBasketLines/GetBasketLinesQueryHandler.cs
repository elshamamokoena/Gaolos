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

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines
{
    public class GetBasketLinesQueryHandler : IRequestHandler<GetBasketLinesQuery, IEnumerable<BasketLinesVm>>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IBasketLineRepository _basketLineRepository;
        private readonly IMapper _mapper;
        public GetBasketLinesQueryHandler(IBasketRepository shoppingBasketRepository, 
            IBasketLineRepository basketLineRepository, IMapper mapper)
        {
            _shoppingBasketRepository = shoppingBasketRepository ?? 
                throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _basketLineRepository = basketLineRepository?? 
                throw new ArgumentNullException(nameof(basketLineRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<BasketLinesVm>> Handle(GetBasketLinesQuery request, CancellationToken cancellationToken)
        {
            if(!await _shoppingBasketRepository.BasketExistsAsync(request.BasketId))
            {
                throw new NotFoundException(nameof(Basket), request.BasketId);
            }
            var basketLines = await _basketLineRepository.GetBasketLinesAsync(request.BasketId);
            return _mapper.Map<IEnumerable<BasketLinesVm>>(basketLines);
        }
    }
}

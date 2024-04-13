using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Queries.GetBasket
{
    public class GetBasketQueryHandler : IRequestHandler<GetBasketQuery, BasketVm>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public GetBasketQueryHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository
                ?? throw new ArgumentNullException(nameof(basketRepository));
            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<BasketVm> Handle(GetBasketQuery request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetBasketAsync(request.BasketId);
            if (basket ==null)
            {
                throw new NotFoundException(nameof(basket), request.BasketId);
            }
            var result= _mapper.Map<BasketVm>(basket);
            result.NumberOfItems = basket.BasketLines.Sum(bl => bl.Quantity);
            result.BasketTotal = basket.BasketLines.Sum(bl => bl.Quantity * bl.MenuItem.Price);
            return result;
        }
    }
}

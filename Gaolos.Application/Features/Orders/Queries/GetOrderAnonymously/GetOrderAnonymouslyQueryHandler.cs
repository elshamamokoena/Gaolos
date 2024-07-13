using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrderAnonymously
{
    public class GetOrderAnonymouslyQueryHandler : IRequestHandler<GetOrderAnonymouslyQuery, AnonymousOrder>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public GetOrderAnonymouslyQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository
                ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<AnonymousOrder> Handle(GetOrderAnonymouslyQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<AnonymousOrder>(await _orderRepository.GetOrder(request.OrderId));
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrdersForUser
{
    public class GetOrdersForUserQueryHandler : IRequestHandler<GetOrdersForUserQuery, IEnumerable<OrderForUserVm>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public GetOrdersForUserQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository
                ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<OrderForUserVm>> Handle(GetOrdersForUserQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetOrdersForUser(request.UserId);
            return _mapper.Map<IEnumerable<OrderForUserVm>>(orders);
        }
    }
}

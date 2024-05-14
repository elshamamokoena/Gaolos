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
    public class GetOrdersForUserQueryHandler : IRequestHandler<GetOrdersForUserQuery, PagedOrdersVm>
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
        public async Task<PagedOrdersVm> Handle(GetOrdersForUserQuery request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetOrdersForUser(request.UserId, request.OrderResourceParameters);

            var ordersToReturn=  _mapper.Map<List<OrderForUserVm>>(orders.ToList());

            return new PagedOrdersVm { 
                Orders = ordersToReturn,
                TotalPages = orders.TotalPages, 
                PageSize = orders.PageSize, 
                CurrentPage = orders.CurrentPage, 
                TotalCount = orders.TotalCount, 
                HasNext = orders.HasNext,
                HasPrevious = orders.HasPrevious
            };
        }
    }
}

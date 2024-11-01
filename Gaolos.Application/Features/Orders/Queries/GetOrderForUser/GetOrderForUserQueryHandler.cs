﻿using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Features.Orders.Queries.GetOrdersForUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Orders.Queries.GetOrderForUser
{
    public class GetOrderForUserQueryHandler : IRequestHandler<GetOrderForUserQuery, DetailedOrderForUserVm>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public GetOrderForUserQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository
                ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<DetailedOrderForUserVm> Handle(GetOrderForUserQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderById(request.UserId,request.OrderId);

            var detailedOrder=  _mapper.Map<DetailedOrderForUserVm>(order);
            foreach (var item in detailedOrder.OrderLines)
            {
                item.Price= item.MenuItem.Price* item.Quantity; 
            }
           return detailedOrder;
        }
    }
}

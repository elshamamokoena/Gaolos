using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class CheckoutCommandHandler : IRequestHandler<CheckoutCommand, CheckoutCommandResponse>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public CheckoutCommandHandler(IBasketRepository shoppingBasketRepository, 
            IOrderRepository orderRepository, IMapper mapper)
        {
            _shoppingBasketRepository = shoppingBasketRepository
                ?? throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _orderRepository = orderRepository
                ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<CheckoutCommandResponse> Handle(CheckoutCommand request, CancellationToken cancellationToken)
        {
            var response = new CheckoutCommandResponse();
            var validator = new CheckoutCommandValidator();
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
            if (response.Success)
            {
                var basket = await _shoppingBasketRepository.GetBasketAsync(request.BasketId);
                if (basket == null)
                {
                    response.Success = false;
                    response.Message = "Basket Not Found";
                    return response;
                }
                if (basket.BasketLines.Count < 1)
                {
                    response.Success = false;
                    response.Message = "Basket is Empty";
                    return response;
                }
                var order = _mapper.Map<Order>(request);
                order.UserId = basket.UserId;
                order.OrderPlaced = DateTime.Now;
                order.OrderTotal = basket.BasketLines.Sum(x => x.Price * x.Quantity);
                order.OrderPaid = false;
                order.OrderLines = _mapper.Map<List<OrderLine>>(basket.BasketLines);
                await _orderRepository.AddOrder(order);
                await _orderRepository.SaveAsync();
                response.Order = _mapper.Map<OrderVm>(order);
            }
            return response;
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Infrastructure;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Models.Mail;
using Gaolos.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
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
        private readonly IEmailService _emailService;
        private readonly ILogger<CheckoutCommandHandler> _logger;
        public CheckoutCommandHandler(IBasketRepository shoppingBasketRepository, 
            IOrderRepository orderRepository, IMapper mapper, 
            IEmailService emailService, ILogger<CheckoutCommandHandler> logger)
        {
            _shoppingBasketRepository = shoppingBasketRepository
                ?? throw new ArgumentNullException(nameof(shoppingBasketRepository));
            _orderRepository = orderRepository
                ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
            _emailService = emailService 
                ?? throw new ArgumentNullException(nameof(emailService));
            _logger = logger 
                ?? throw new ArgumentNullException(nameof(logger));
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

            if (response.Success)
            {
            
                var order = _mapper.Map<Order>(request);
                order.UserId = basket.UserId;
                order.OrderPlaced = DateTime.Now;
                order.OrderTotal = basket.BasketLines.Sum(x => x.Price * x.Quantity);
                order.OrderPaid = false;
                order.OrderLines = _mapper.Map<List<OrderLine>>(basket.BasketLines);
                await _orderRepository.AddOrder(order);
                await _orderRepository.SaveAsync();
                response.Order = _mapper.Map<OrderVm>(order);
                await _shoppingBasketRepository.ClearBasket(basket.BasketId);

                //Send Email
                
                var email = new Email(new List<string> { "elshamamokoena@gmail.com" },
                    $"Order {order.OrderId}", 
                    _emailService.GetEmailTemplate("OrderConfirmation", response.Order));
                
                var result = await _emailService.SendAsync(email, new CancellationToken());
                if (result)
                {
                    response.Message = "Order has been placed and email sent";
                }
                else
                {
                    response.Message = "Order has been placed but email failed";
                    _logger.LogError($"Email sending failed");
                }
             
            }
            return response;
        }
    }
}

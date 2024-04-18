using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.ApplyCouponToBasket
{
    public class ApplyCouponToBasketHandler:IRequestHandler<ApplyCouponToBasketCommand, ApplyCouponToBasketCommandResponse>
    {
        private readonly IBasketRepository _shoppingBasketRepository;
        public ApplyCouponToBasketHandler(IBasketRepository shoppingBasketRepository)
        {
            _shoppingBasketRepository = shoppingBasketRepository;
        }
        public async Task<ApplyCouponToBasketCommandResponse> Handle(ApplyCouponToBasketCommand request, CancellationToken cancellationToken)
        {

            var response = new ApplyCouponToBasketCommandResponse();
            var validator = new ApplyCouponToBasketCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if(validationResult.Errors.Count > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            var basket = await _shoppingBasketRepository.GetBasketAsync(request.BasketId);
            if(basket == null)
            {
                throw new NotFoundException(nameof(basket), request.BasketId);
            }
            basket.CouponId = request.Coupon.CouponId;
            await  _shoppingBasketRepository.SaveAsync();
            response.Message= "Coupon Applied to Basket";
            return response;


        }
    }
    
}

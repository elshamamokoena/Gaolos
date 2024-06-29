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
        private readonly ICouponRepository _couponRepository;
        public ApplyCouponToBasketHandler(IBasketRepository shoppingBasketRepository, 
            ICouponRepository couponRepository)
        {
            _shoppingBasketRepository = shoppingBasketRepository;
            _couponRepository = couponRepository;
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

            if (!string.IsNullOrWhiteSpace(request.CouponCode))
            {
                var coupoun = await _couponRepository.GetCouponByCode(request.CouponCode);
                basket.CouponId = coupoun.CouponId;
                await _shoppingBasketRepository.SaveAsync();

                response.Message = "Coupon Applied to Basket";
            }
            if(request.CouponId != null)
            {
                
            basket.CouponId = request.CouponId;
            await _shoppingBasketRepository.SaveAsync();

                response.Message= "Coupon Applied to Basket";
            }

            return response;


        }
    }
    
}

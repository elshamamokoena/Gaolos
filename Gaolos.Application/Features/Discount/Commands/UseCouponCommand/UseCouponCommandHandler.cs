using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Models.Discount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Commands.UseCouponCommand
{
    public class UseCouponCommandHandler : IRequestHandler<UseCouponCommand, UseCouponCommandResponse>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;
        public UseCouponCommandHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository
                ?? throw new ArgumentNullException(nameof(couponRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<UseCouponCommandResponse> Handle(UseCouponCommand request, CancellationToken cancellationToken)
        {
            await _couponRepository.UseCoupon(request.CouponId);
            var response = new UseCouponCommandResponse();
            var validator = new UseCouponCommandValidator();
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
            response.coupon = _mapper.Map<CouponVm>( await _couponRepository.GetCouponById(request.CouponId));
            return response;
        }
    }
}

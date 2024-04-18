using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Application.Models.Discount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Queries.GetCouponById
{
    public class GetCouponByIdQueryHandler : IRequestHandler<GetCouponByIdQuery, CouponVm>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;
        public GetCouponByIdQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository
                ?? throw new ArgumentNullException(nameof(couponRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async  Task<CouponVm> Handle(GetCouponByIdQuery request, CancellationToken cancellationToken)
        {
            var coupon = await _couponRepository.GetCouponById(request.CouponId);
            if (coupon == null)
            {
                throw new NotFoundException(nameof(coupon), request.CouponId);
            }
            return _mapper.Map<CouponVm>(coupon);
        }
    }
}

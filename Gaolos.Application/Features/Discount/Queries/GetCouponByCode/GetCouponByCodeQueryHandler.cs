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

namespace Gaolos.Application.Features.Discount.Queries.GetCouponByCode
{
    public class GetCouponByCodeQueryHandler : IRequestHandler<GetCouponByCodeQuery, CouponVm>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public GetCouponByCodeQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository
                ?? throw new ArgumentNullException(nameof(couponRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<CouponVm> Handle(GetCouponByCodeQuery request, CancellationToken cancellationToken)
        {
            var coupon = await _couponRepository.GetCouponByCode(request.Code);
            if (coupon == null)
            {
                throw new NotFoundException(nameof(coupon), request.Code);
            }
            return _mapper.Map<CouponVm>(coupon);
        }
    }
}

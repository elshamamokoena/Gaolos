using Gaolos.Domain.Entities.Discount;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface ICouponRepository
    {
        Task AddCoupon(Coupon coupon);
        Task<Coupon> GetCouponByCode(string code);
        Task<Coupon> GetCouponById(Guid couponId);
        Task UseCoupon(Guid couponId);
    }
}
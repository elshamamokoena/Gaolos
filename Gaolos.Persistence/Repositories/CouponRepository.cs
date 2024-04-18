using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities.Discount;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        private readonly GaolosDbContext _context;

        public CouponRepository(GaolosDbContext context)
        {
            _context = context;
        }

        public async Task<Coupon> GetCouponByCode(string code)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Coupons.FirstOrDefaultAsync(c => c.Code == code);
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task<Coupon> GetCouponById(Guid couponId)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Coupons.FirstOrDefaultAsync(c => c.CouponId == couponId);
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task AddCoupon(Coupon coupon)
        {
            await _context.Coupons.AddAsync(coupon);
        }
        public async Task UseCoupon(Guid couponId)
        {
            var couponToUpdate =
                await _context.Coupons.FirstOrDefaultAsync(c => c.CouponId == couponId);
            if (couponToUpdate != null)
            {
                throw new Exception("Coupon not found");
            }

            couponToUpdate.AlreadyUsed = true;
            await _context.SaveChangesAsync();
        }
    }
}

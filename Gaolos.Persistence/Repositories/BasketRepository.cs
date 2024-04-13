using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities.ShoppingCart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly GaolosDbContext _dbContext;
        public BasketRepository(GaolosDbContext gaolosDbContext)
        {
            _dbContext = gaolosDbContext 
                ?? throw new ArgumentNullException(nameof(gaolosDbContext));
        }

        public void AddBasket(Basket basket)
        {
            _dbContext.Baskets.Add(basket);
        }

        public async Task<bool> BasketExistsAsync(Guid basketId)
        {
            if(basketId == Guid.Empty) throw new ArgumentNullException(nameof(basketId));

            return  await _dbContext.Baskets.AnyAsync(b => b.BasketId == basketId);

        }

        public async Task ClearBasket(Guid basketId)
        {
            if(basketId == Guid.Empty) throw new ArgumentNullException(nameof(basketId));

            var basketLinesToRemove = _dbContext.BasketLines.Where(b => b.BasketId == basketId);
            _dbContext.BasketLines.RemoveRange(basketLinesToRemove);

            var basket= _dbContext.Baskets.FirstOrDefault(b => b.BasketId == basketId);
            if(basket != null) basket.CouponId = null;
            
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Basket> GetBasketAsync(Guid basketId)
        {
            if(basketId == Guid.Empty) throw new ArgumentNullException(nameof(basketId));

        #pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Baskets.Include(b => b.BasketLines)
                        .Where(b => b.BasketId == basketId).FirstOrDefaultAsync();
        #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<bool> SaveAsync()
        {
            return (await _dbContext.SaveChangesAsync() > 0);
        }
    }
}

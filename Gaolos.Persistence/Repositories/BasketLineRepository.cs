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
    public class BasketLineRepository : IBasketLineRepository
    {
        private readonly GaolosDbContext _dbContext;

        public BasketLineRepository(GaolosDbContext dbContext)
        {
            _dbContext = dbContext
                ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public async Task<BasketLine> AddOrUpdateBasketLine(Guid BasketId, BasketLine basketLine)
        {
            if(BasketId == Guid.Empty) throw new ArgumentNullException(nameof(BasketId));

            if(basketLine == null) throw new ArgumentNullException(nameof(basketLine));

            var existingBasketLine = await _dbContext.BasketLines
                .Include(bl=>bl.MenuItem)
                .FirstOrDefaultAsync(b => b.BasketId == BasketId && b.MenuItemId == basketLine.MenuItemId);

            if(existingBasketLine == null)
            {
                basketLine.BasketId = BasketId;
                _dbContext.BasketLines.Add(basketLine);
                return basketLine;
            }
            
            existingBasketLine.Quantity += basketLine.Quantity;

            return existingBasketLine;
        }

        public async Task<BasketLine> GetBasketLineAsync(Guid basketLineId)
        {
            if(basketLineId == Guid.Empty) throw new ArgumentNullException(nameof(basketLineId));

            #pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.BasketLines
                .Include(bl => bl.MenuItem)
                .FirstOrDefaultAsync(b => b.BasketLineId == basketLineId);
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<BasketLine>> GetBasketLinesAsync(Guid basketId)
        {
            if(basketId == Guid.Empty) throw new ArgumentNullException(nameof(basketId));

            return await _dbContext.BasketLines
                .Include(bl => bl.MenuItem)
                .Where(b => b.BasketId == basketId)
                .ToListAsync();
        }

        public void RemoveBasketLine(BasketLine basketLine)
        {
            _dbContext.BasketLines.Remove(basketLine);
        }

        public async Task<bool> SaveAsync()
        {
            return (await _dbContext.SaveChangesAsync()>0);
        }

        public void UpdateBasketLine(BasketLine basketLine)
        {
            // empty on purpose
        }
    }
}

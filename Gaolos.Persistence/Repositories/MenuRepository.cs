using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly GaolosDbContext _dbContext;
        public MenuRepository(GaolosDbContext dbContext)
        { 
            _dbContext = dbContext ??
                throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Menu> GetMenuAsync(Guid restaurantId, Guid menuId)
        {
             if (restaurantId == Guid.Empty) throw new ArgumentNullException(nameof(restaurantId));
             if (menuId == Guid.Empty) throw new ArgumentNullException(nameof(menuId));

             #pragma warning disable CS8603 // Possible null reference return.
             return await _dbContext.Menus
                    .Where(r => r.RestaurantId == restaurantId && r.MenuId == menuId)
                    .FirstOrDefaultAsync();
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Menu>> GetMenusAsync(Guid restaurantId)
        {
            if (restaurantId == Guid.Empty) throw new ArgumentNullException(nameof(restaurantId));

            return await _dbContext.Menus
                .Where(r => r.RestaurantId == restaurantId)
                .ToListAsync();

        }

        public async Task<bool> MenuExistsAsync(Guid menuId)
        {
            return await _dbContext.Menus.AnyAsync(m => m.MenuId == menuId);
        }
    }
}

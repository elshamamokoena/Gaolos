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
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {

        public MenuRepository(GaolosDbContext dbContext)
            :base(dbContext)
        { 
        }
        public async Task<Menu> GetMenuAsync(Guid restaurantId)
        {
            if(restaurantId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(restaurantId));
            }

            #pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Menus.FirstOrDefaultAsync(m=>m.RestaurantId==restaurantId);
            #pragma warning restore CS8603 // Possible null reference return.

        }

        public async Task<bool> MenuExistsAsync(Guid menuId)
        {
            if(menuId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(menuId));
            }
            return await _dbContext.Menus.AnyAsync(m=>m.MenuId==menuId);
        }
    }
}

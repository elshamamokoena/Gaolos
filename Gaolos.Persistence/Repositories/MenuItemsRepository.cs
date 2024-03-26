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
    public class MenuItemsRepository:IMenuItemsRepository
    {
        private readonly GaolosDbContext _dbContext;
        public MenuItemsRepository(GaolosDbContext dbContext)
        {
            _dbContext = dbContext 
                ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<MenuItem> GetMenuItemAsync(Guid menuId, Guid menuItemId)
        {
            if (menuId == Guid.Empty) throw new ArgumentNullException(nameof(menuId));
            if (menuItemId == Guid.Empty)  throw new ArgumentNullException(nameof(menuItemId));

            #pragma warning disable CS8603
            return await _dbContext.MenuItems.Where(i => i.MenuId == menuId && i.MenuItemId == menuItemId).FirstOrDefaultAsync();
            #pragma warning restore CS8603

        }

        public async Task<IEnumerable<MenuItem>> GetMenuItemsAsync(Guid menuId)
        {
            if(menuId == Guid.Empty) throw new ArgumentNullException( nameof(menuId));

            return await _dbContext.MenuItems
                .Where(m=>m.MenuId==menuId)
                .ToListAsync();
        }
    }
}

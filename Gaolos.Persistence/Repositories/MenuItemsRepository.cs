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
    public class MenuItemsRepository:BaseRepository<MenuItem>, IMenuItemsRepository
    {
        public MenuItemsRepository(GaolosDbContext dbContext):base(dbContext) { }

        public async Task<MenuItem> GetMenuItemAsync(Guid subMenuId, Guid menuItemId)
        {
            if (subMenuId == Guid.Empty) throw new ArgumentNullException(nameof(subMenuId));
            if (menuItemId == Guid.Empty)  throw new ArgumentNullException(nameof(menuItemId));

            #pragma warning disable CS8603
            return await _dbContext.MenuItems.Where(i => i.SubMenuId == subMenuId && i.MenuItemId == menuItemId).FirstOrDefaultAsync();
            #pragma warning restore CS8603

        }

        public async Task<IEnumerable<MenuItem>> GetMenuItemsAsync(Guid subMenuId)
        {
            if(subMenuId == Guid.Empty) throw new ArgumentNullException( nameof(subMenuId));

            return await _dbContext.MenuItems
                .Where(m=>m.SubMenuId==subMenuId)
                .ToListAsync();
        }
    }
}

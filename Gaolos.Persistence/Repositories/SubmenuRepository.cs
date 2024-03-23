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
    public class SubmenuRepository : BaseRepository<Submenu>, ISubmenuRepository
    {
        public SubmenuRepository(GaolosDbContext dbContext):base(dbContext) 
        { }

        public Task<Submenu> GetSubmenuAsync(Guid menuId, Guid subMenuId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Submenu>> GetSubmenusAsync(Guid menuId)
        {
            if(menuId == Guid.Empty) throw new ArgumentNullException(nameof(menuId));

            return await _dbContext.Submenus
                            .Where(s=>s.MenuId==menuId)
                            .OrderBy(s=>s.Name)
                            .ToListAsync();
        }

        public async Task<bool> SubMenuExistsAsync(Guid subMenuId)
        {
            if (subMenuId == Guid.Empty) throw new ArgumentNullException(nameof(subMenuId));
            return await _dbContext.Submenus
                          .AnyAsync(s=>s.MenuId==subMenuId);
        }
    }
}

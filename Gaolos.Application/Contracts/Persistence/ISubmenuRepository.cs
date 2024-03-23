using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface ISubmenuRepository
    {
        Task<IEnumerable<Submenu>> GetSubmenusAsync(Guid menuId);
        Task<Submenu> GetSubmenuAsync(Guid menuId, Guid subMenuId);

        Task<bool> SubMenuExistsAsync(Guid subMenuId);

    }
}

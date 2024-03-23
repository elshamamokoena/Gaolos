using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IMenuItemsRepository
    {
        Task<IEnumerable<MenuItem>> GetMenuItemsAsync(Guid subMenuId);
        Task<MenuItem> GetMenuItemAsync(Guid subMenuId, Guid menuItemId);
    }
}

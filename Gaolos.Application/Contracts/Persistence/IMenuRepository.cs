using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IMenuRepository
    {
        Task<Menu> GetMenuAsync(Guid restaurantId);
    
 
        Task<bool> MenuExistsAsync(Guid menuId);

    }
}

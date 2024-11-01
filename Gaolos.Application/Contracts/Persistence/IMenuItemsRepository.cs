﻿using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IMenuItemsRepository
    {
        Task<IEnumerable<MenuItem>> GetMenuItemsAsync(Guid menuId);
        Task<MenuItem> GetMenuItemAsync(Guid menuId, Guid menuItemId);
        Task<bool> MenuItemExists(Guid menuItemId);
    }
}

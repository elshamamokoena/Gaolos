﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu
{
    public class MenuItemForMenuDto
    {
        public Guid MenuItemId { get; set; }
        public string Name { get; set; } 
        public decimal Price { get; set; }
    }
}

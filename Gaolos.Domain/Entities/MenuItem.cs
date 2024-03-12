using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class MenuItem:AuditableEntity
    {
        public Guid MenuItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid SubMenuId { get; set; }
        public Submenu Submenu { get; set; } = default!;

    }
}

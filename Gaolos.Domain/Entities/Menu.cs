using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class Menu: AuditableEntity
    {
        public Guid MenuId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = default!;
        public ICollection<Submenu>? Submenus { get; set;}
    }
}

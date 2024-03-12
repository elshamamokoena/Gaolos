using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class Submenu:AuditableEntity
    {
        public Guid SubmenuId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; } = default!;
        public ICollection<MenuItem>? menuItems { get; set; }

    }
}

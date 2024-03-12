using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class Category:AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ? ImageUrl { get; set; }
        public string? SvgUrl { get; set; }
        public ICollection<Restaurant>? Restaurants { get; set; }
    }
}

using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class Restaurant : AuditableEntity
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? logoUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;

    }
}

using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; } = null!;
        public Guid RestaurantId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;
        public Guid CategoryId { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; } 
            = new List<MenuItem>();
    }
}

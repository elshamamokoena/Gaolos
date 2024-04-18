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
    public class MenuItem:AuditableEntity
    {
        [Key]
        public Guid MenuItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid MenuId { get; set; }
        [ForeignKey(nameof(MenuId))]
        public Menu Menu { get; set; } = null!;

    }
}

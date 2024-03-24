using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities
{
    public class Category:AuditableEntity
    {
        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string ? ImageUrl { get; set; }
        public string? SvgUrl { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; } 
            = new List<Restaurant>();
    }
}

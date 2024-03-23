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
    public class Restaurant : AuditableEntity
    {
        [Key]
        public Guid RestaurantId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(1500)]
        public string ? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string? LogoUrl { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;
        public Guid CategoryId { get; set; }
        public Menu? Menu { get; set; } 

        //public Restaurant(string name, string ? description, string ?imageUrl, string ? logoUrl) 
        //{
        //    Name = name;
        //    Description = description;
        //    ImageUrl = imageUrl;
        //    LogoUrl = logoUrl;
        //}

    }
}

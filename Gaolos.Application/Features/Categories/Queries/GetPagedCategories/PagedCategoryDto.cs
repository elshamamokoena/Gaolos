using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Queries.GetPagedCategories
{
    public class PagedCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}

using Gaolos.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesList
{
    public class PagedCategoriesVm:PagedResourceListVm
    {
        public ICollection<CategoryListVm>? Categories { get; set; }
    }
}

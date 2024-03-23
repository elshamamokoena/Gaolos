using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Queries.GetPagedCategories
{
    public class GetPagedCategoriesQuery:IRequest<PagedCategoriesVm>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}

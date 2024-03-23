using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Queries.GetCategory
{
    public class GetCategoryQuery:IRequest<CategoryDetailDto>
    {
        public Guid CategoryId { get; set; }
    }
}

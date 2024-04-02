using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;

namespace Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent
{
    public class CreateCategoryWithParentCategoryDto : CreateCategoryDto
    {
        public Guid ParentCategoryId { get; set; }
    }
}

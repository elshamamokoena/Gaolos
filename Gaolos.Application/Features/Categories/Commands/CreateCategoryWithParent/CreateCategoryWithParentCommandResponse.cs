using Gaolos.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent
{
    public class CreateCategoryWithParentCommandResponse:BaseResponse
    {
        public CreateCategoryWithParentCommandResponse():base()
        {

        }

        public CreateCategoryWithParentCategoryDto Category { get; set; }= default!;
    }
}

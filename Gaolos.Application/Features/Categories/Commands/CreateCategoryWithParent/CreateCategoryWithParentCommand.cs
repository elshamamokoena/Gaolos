using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent
{
    public class CreateCategoryWithParentCommand: IRequest<CreateCategoryWithParentCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
        public Guid ParentCategoryId { get; set; }
    }
}

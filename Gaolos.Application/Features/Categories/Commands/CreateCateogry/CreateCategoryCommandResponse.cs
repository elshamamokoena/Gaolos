using Gaolos.Application.Responses;

namespace Gaolos.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
     //   public CreateCategoryWithParentCategoryDto CategoryWithParentCategory { get; set; } = default!;
    }
}
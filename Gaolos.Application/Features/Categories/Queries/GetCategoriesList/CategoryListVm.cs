namespace Gaolos.Application.Features.Categories.Queries.GetCategoriesList
{

    //  CategoryListVm => CategoryListDto
    public class CategoryListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string ImageUrl { get; set; }= string.Empty;
        public string SvgUrl { get; set; } = string.Empty;
    }
}

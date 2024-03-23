namespace Gaolos.Web.App.ViewModels
{
    public class PagedCategoriesViewModel
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<CategoryViewModel>? PagedCategories { get; set; }
    }
}

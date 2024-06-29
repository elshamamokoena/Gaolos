namespace Gaolos.Web.App.ViewModels
{
    public class MenuItemViewModel
    {
        public Guid MenuItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
}

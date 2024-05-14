namespace Gaolos.Web.App.ViewModels.Account
{
    public class OrderLineViewModel
    {
        public Guid OrderLineId { get; set; }
        public Guid MenuItemId { get; set; }
        public MenuItemViewModel ? MenuItem { get; set; } 
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

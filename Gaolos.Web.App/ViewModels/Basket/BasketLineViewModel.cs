namespace Gaolos.Web.App.ViewModels.Basket
{
    public class BasketLineViewModel
    {
        public Guid BasketLineId { get; set; }
        public Guid MenuItemId { get; set; }
        
        public double Price { get; set; }
        public int Quantity { get; set; }
        public MenuItemViewModel ?MenuItem { get; set; }
    }
}

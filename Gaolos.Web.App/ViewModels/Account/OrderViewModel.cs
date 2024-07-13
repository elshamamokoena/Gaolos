namespace Gaolos.Web.App.ViewModels.Account
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public string OrderStatus { get; set; }
        public string OrderPlaced { get; set; }
        public ICollection<OrderLineViewModel> OrderLines { get; set; }
        public int OrderTotal { get; set; } 
    }
}

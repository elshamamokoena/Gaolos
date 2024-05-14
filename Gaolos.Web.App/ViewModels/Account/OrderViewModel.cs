namespace Gaolos.Web.App.ViewModels.Account
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderPlaced { get; set; }
        public ICollection<OrderLineViewModel> OrderLines { get; set; }
        public int OrderTotal { get; set; } 
    }
}

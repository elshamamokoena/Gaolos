namespace Gaolos.Web.App.ViewModels.Basket
{
    public class BasketViewModel
    {
        public Guid BasketId { get; set; }
        public double BasketTotal { get; set; } =0;
        public Guid ? CouponId { get; set; }
        public int NumberOfItems { get; set; } = 0;
        //public IEnumerable<BasketLineViewModel> BasketLines { get; set; }
        //    = new List<BasketLineViewModel>();

    }
}

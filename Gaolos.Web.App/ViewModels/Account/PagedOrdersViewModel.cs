namespace Gaolos.Web.App.ViewModels.Account
{
    public class PagedOrdersViewModel:ListViewModel
    {
        public ICollection<OrderViewModel> ? Orders { get; set; }
 
    }
}

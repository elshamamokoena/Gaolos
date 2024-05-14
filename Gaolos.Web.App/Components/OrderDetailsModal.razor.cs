using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class OrderDetailsModal
    {
        [Parameter]
        public ICollection<OrderLineViewModel> OrderLines { get; set; }
    }
}

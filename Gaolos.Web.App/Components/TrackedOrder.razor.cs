using Gaolos.Web.App.ViewModels.Account;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class TrackedOrder
    {
        [Parameter]
        public OrderViewModel? Order { get; set; }
        [Parameter]
        public EventCallback<Guid> OnShowOrderDetails { get; set; }

    }
}

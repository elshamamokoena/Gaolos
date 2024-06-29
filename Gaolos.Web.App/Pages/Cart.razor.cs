using Gaolos.Web.App.Components.Cart;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class Cart
    {
        [SupplyParameterFromQuery(Name ="checkout")]
        [Parameter]
        public bool Checkout { get; set; }
        public Type Widget { get; set; }

        [Inject]
        public ApplicationState ApplicationState { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Widget = typeof(Order);
            await base.OnInitializedAsync();
        }

        protected override async Task OnParametersSetAsync()
        {
            if (Checkout)
            {
                Widget = typeof(Checkout);
            }

            await base.OnParametersSetAsync();
        }

        public void SelectWidget(Type widget)
        {
            Widget = widget;
        }

    }
}

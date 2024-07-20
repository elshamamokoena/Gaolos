using Fluxor;
using Gaolos.Web.App.Components.Cart;
using Gaolos.Web.App.Store.CartState;
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
        public IState<CartSummaryState> CartState { get; set; }
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Widget = typeof(Order);

            await base.OnInitializedAsync();
         //   Dispatcher.Dispatch(new FetchDataAction());

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

using Fluxor;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Store.CartState;
using Gaolos.Web.App.ViewModels.Basket;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Cart
{
    public partial class CheckoutSummary
    {
         public BasketViewModel Basket { get; set; }
        = new BasketViewModel();
        [Inject]
        public IShoppingBasketService ShoppingBasketService { get; set; }
        [Inject]
        public IState<CartSummaryState> State { get; set; }
       
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
           // Dispatcher.Dispatch(new FetchDataAction());
        }


    }
}

using Fluxor;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels.Basket;

namespace Gaolos.Web.App.Store.CartState
{
    [FeatureState]
    public class CartSummaryState
    {
        public bool IsLoading { get;}
        public int ItemCount { get; }

        public BasketViewModel Basket { get;}
        public IEnumerable<BasketLineViewModel> BasketLines { get; }

        private CartSummaryState() { } // Required for creating initial state

        public CartSummaryState(BasketViewModel basket, IEnumerable<BasketLineViewModel> basketLines,
            bool isLoading)
        {
         
            IsLoading = isLoading;
           Basket= basket;
            BasketLines = basketLines;
            ItemCount = Basket!=null? 
                Basket.NumberOfItems:0;
        }
    }
}

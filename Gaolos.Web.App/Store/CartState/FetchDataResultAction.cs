using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels.Basket;

namespace Gaolos.Web.App.Store.CartState
{
    public class FetchDataResultAction
    {
        public  BasketViewModel Basket { get; }
        public IEnumerable<BasketLineViewModel> Basketlines { get; }


        public FetchDataResultAction(BasketViewModel basket,
            IEnumerable<BasketLineViewModel> basketlines)
        {
            Basket = basket;
            Basketlines = basketlines;
        }
    }
}

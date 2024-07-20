using Blazored.LocalStorage;
using Fluxor;
using Gaolos.Web.App.Contracts;

namespace Gaolos.Web.App.Store.CartState
{
    public class Effects
    {
        private readonly IShoppingBasketService ShoppingBasketService;
        private readonly ILocalStorageService LocalStorageService;
        public Effects(IShoppingBasketService shoppingBasketService, 
            ILocalStorageService localStorageService)
        {
            ShoppingBasketService = shoppingBasketService;
            LocalStorageService = localStorageService;
        }
        [EffectMethod]
        public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
        {
            var basketId = await LocalStorageService.GetItemAsync<Guid>("BasketId");
            var basket = await ShoppingBasketService.GetBasket(basketId:basketId);
            var lines = await ShoppingBasketService.GetBasketLines(basketId:basketId);
            dispatcher.Dispatch(new FetchDataResultAction(basket, lines));
        }
    }
}

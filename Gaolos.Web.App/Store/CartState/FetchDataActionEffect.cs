using Blazored.LocalStorage;
using Fluxor;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;

namespace Gaolos.Web.App.Store.CartState
{
    public class FetchDataActionEffect : Effect<FetchDataAction>
    {
        private readonly IShoppingBasketService ShoppingBasketService;
        private readonly ILocalStorageService LocalStorageService;

        public FetchDataActionEffect(IShoppingBasketService shoppingBasketService, ILocalStorageService localStorageService)
        {
            ShoppingBasketService = shoppingBasketService;
            LocalStorageService = localStorageService;
        }
        public override async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            var basketId = await LocalStorageService.GetItemAsync<Guid>("BasketId");
            
            if (basketId == Guid.Empty)
            {
                var response = await ShoppingBasketService.CreateBasket();
                if (response.Success)
                {
                    basketId = response.Data.BasketId;
                    await LocalStorageService.SetItemAsync("BasketId", basketId);
                    var lines= await ShoppingBasketService.GetBasketLines(basketId);
                    dispatcher.Dispatch(new FetchDataResultAction(response.Data, lines));

                }
            }
            else
            {
                var basket = await ShoppingBasketService.GetBasket(basketId);
                var lines = await ShoppingBasketService.GetBasketLines(basketId);
                dispatcher.Dispatch(new FetchDataResultAction(basket, lines));
            }
        }
    }
}

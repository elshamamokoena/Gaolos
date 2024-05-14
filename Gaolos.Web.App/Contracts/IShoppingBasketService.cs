using Gaolos.Web.App.Services;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account;
using Gaolos.Web.App.ViewModels.Basket;

namespace Gaolos.Web.App.Contracts
{
    public interface IShoppingBasketService
    {
        Task<BasketViewModel> GetBasket(Guid basketId);
        Task<ApiResponse<BasketViewModel>> CreateBasket();
        Task<ApiResponse> ApplyCouponToBasket(Guid basketId, Guid couponId);
        Task<ApiResponse> ApplyCouponToBasket(Guid basketId, string couponCode);
        Task<ApiResponse<OrderViewModel>> Checkout(CheckoutViewModel checkout);

        Task<IEnumerable<BasketLineViewModel>>  GetBasketLines(Guid basketId);
        Task<BasketLineViewModel> GetBasketLine(Guid basketId, Guid basketLineId);
        Task<ApiResponse<BasketLineViewModel>> AddItemToBasket(Guid basketId, MenuItemViewModel item);
        Task UpdateBasketLine(Guid basketId, Guid basketLineId, int Quantity);
        Task RemoveItemFromBasket(Guid basketId, Guid basketLineId);

    }
}

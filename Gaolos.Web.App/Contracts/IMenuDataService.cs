using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Contracts
{
    public interface IMenuDataService
    {
        Task<List<MenuViewModel>> GetMenusForRestaurant(Guid restaurantId);
        Task<List<MenuItemViewModel>> GetMenuItemsForMenu(Guid menuId, Guid restaurantId);
    }
}

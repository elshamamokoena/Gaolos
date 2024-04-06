using AutoMapper;
using Blazored.LocalStorage;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Services
{
    public class MenuDataService :BaseDataService, IMenuDataService
    {
        private readonly IMapper _mapper;

        public MenuDataService(IClient client, IMapper mapper, ILocalStorageService localStorage)
            :base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<List<MenuItemViewModel>> GetMenuItemsForMenu(Guid menuId, Guid restaurantId)
        {
            var items =await _client.GetMenuItemsForMenuAsync(menuId,restaurantId.ToString());
            return _mapper.Map<List<MenuItemViewModel>>(items);
        }

        public async Task<List<MenuViewModel>> GetMenusForRestaurant(Guid restaurantId)
        {
            var menus = await _client.GetMenusForRestaurantAsync(restaurantId);
            return _mapper.Map<List<MenuViewModel>>(menus);

        }
    }
}

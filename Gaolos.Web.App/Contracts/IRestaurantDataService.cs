using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Contracts
{
    public interface IRestaurantDataService
    {
        Task<List<RestaurantListViewModel>> GetAllRestaurants();
        Task<RestaurantDetailViewModel> GetRestaurantById(Guid id);
        Task<ApiResponse<Guid>> CreateRestaurant(RestaurantDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> UpdateRestaurant(RestaurantDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> DeleteRestaurant(Guid id);
    }
}

using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Contracts
{
    public interface IRestaurantDataService
    {
        Task<RestaurantListViewModel> GetRestaurants(string? tag,string? searchQuery, int? pageSize, int ?pageNumber,
            string ? orderBy, string? fields);
        Task<RestaurantViewModel> GetRestaurant(Guid restaurantId, string? fields, string ? accept);

        //Task<ApiResponse<Guid>> CreateRestaurant(RestaurantDetailViewModel eventDetailViewModel);
        //Task<ApiResponse<Guid>> UpdateRestaurant(RestaurantDetailViewModel eventDetailViewModel);
        //Task<ApiResponse<Guid>> DeleteRestaurant(Guid id);
    }
}

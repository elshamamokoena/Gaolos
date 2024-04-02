using Gaolos.Application.Helpers;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IRestaurantRepository // : IAsyncRepository<Restaurant>
    {
        //Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

        //Task<IEnumerable<Restaurant>> GetRestaurantsAsync(Guid categoryId);
        Task<IEnumerable<Restaurant>> GetRestaurantsAsync();

        Task<PagedList<Restaurant>> GetRestaurantsAsync(RestaurantResourceParameters resourceParameters);

        Task<Restaurant> GetRestaurantAsync(Guid restaurantId);
        // Task<Restaurant> GetRestaurantAsync(Guid restaurantId);

        //   void AddRestaurant(Guid categoryId, Restaurant restaurant);
        //   void UpdateRestaurant(Restaurant restaurant);
        //   void DeleteRestaurant(Restaurant restaurant);
        Task<bool> RestaurantExistsAsync(Guid restaurantId);



    }
}

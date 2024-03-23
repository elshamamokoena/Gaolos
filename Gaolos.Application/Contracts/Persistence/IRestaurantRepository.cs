using Gaolos.Domain.Entities;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IRestaurantRepository // : IAsyncRepository<Restaurant>
    {
        //Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

        Task<IEnumerable<Restaurant>> GetRestaurantsAsync(Guid categoryId);
        Task<Restaurant> GetRestaurantAsync(Guid categoryId, Guid restaurantId);
        void AddRestaurant(Guid categoryId, Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(Restaurant restaurant);


    }
}

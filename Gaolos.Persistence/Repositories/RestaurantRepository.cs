using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private readonly GaolosDbContext _dbContext;
        public RestaurantRepository(GaolosDbContext dbContext)
        {
            _dbContext = dbContext ??
                throw new ArgumentNullException(nameof(dbContext));
        }

        public void AddRestaurant(Guid categoryId, Restaurant restaurant)
        {
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            if (restaurant == null)
            {
                throw new ArgumentNullException(nameof(restaurant));
            }

            // always set the CategoryId to the passed-in categoryId
            restaurant.CategoryId = categoryId;
            _dbContext.Restaurants.Add(restaurant);
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            _dbContext.Restaurants.Remove(restaurant);

        }

        public async Task<Restaurant> GetRestaurantAsync(Guid categoryId, Guid restaurantId)
        {
            if(categoryId == Guid.Empty) throw new ArgumentNullException(nameof(categoryId));
            if (restaurantId == Guid.Empty) throw new ArgumentNullException(nameof(restaurantId));

            #pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Restaurants
                 .Where(r => r.CategoryId == categoryId && r.RestaurantId == restaurantId)
                .FirstOrDefaultAsync();
            #pragma warning restore CS8603 // Possible null reference return.

        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsAsync(Guid categoryId)
        {
            //check if categoryId is null in the query handler
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            return await _dbContext.Restaurants
                        .Where(r => r.CategoryId == categoryId)
                        .OrderBy(r => r.Name).ToListAsync();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            // no code in this one
        }

        //public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        //{
        //    var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
        //    return Task.FromResult(matches);
        //}
    }
}

using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities;
using Gaolos.Application.Helpers;
using Microsoft.EntityFrameworkCore;
using Gaolos.Persistence.Helpers;
using Gaolos.Application.Models.Restaurant;

namespace Gaolos.Persistence.Repositories
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private readonly GaolosDbContext _dbContext;
        private readonly IPropertyMappingService _propertyMappingService;

        public RestaurantRepository(GaolosDbContext dbContext, IPropertyMappingService propertyMappingService)
        {
            _dbContext = dbContext ??
                throw new ArgumentNullException(nameof(dbContext));
            _propertyMappingService = propertyMappingService;
        }

        public void AddRestaurant(Guid categoryId, Restaurant restaurant)
        {
            //if (categoryId == Guid.Empty)
            //{
            //    throw new ArgumentNullException(nameof(categoryId));
            //}

            //if (restaurant == null)
            //{
            //    throw new ArgumentNullException(nameof(restaurant));
            //}

            //// always set the CategoryId to the passed-in categoryId
            //restaurant.CategoryId = categoryId;
            //_dbContext.Restaurants.Add(restaurant);
            throw new NotImplementedException();

        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            _dbContext.Restaurants.Remove(restaurant);

        }

        public async Task<Restaurant> GetRestaurantAsync( Guid restaurantId)
        {
            //if(categoryId == Guid.Empty) throw new ArgumentNullException(nameof(categoryId));
            if (restaurantId == Guid.Empty) throw new ArgumentNullException(nameof(restaurantId));

#pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Restaurants
                 .Where(r => r.RestaurantId == restaurantId)
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.

        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsAsync(Guid categoryId)
        {
            //check if categoryId is null in the query handler
            //if (categoryId == Guid.Empty)
            //{
            //    throw new ArgumentNullException(nameof(categoryId));
            //}

            //return await _dbContext.Restaurants
            //            .Where(r => r.CategoryId == categoryId)
            //            .OrderBy(r => r.Name).ToListAsync();
            throw new NotImplementedException();

        }

        public async Task<PagedList<Restaurant>> GetRestaurantsAsync(RestaurantResourceParameters resourceParameters)
        {
            if(resourceParameters == null)
            {
                throw new ArgumentNullException(nameof(resourceParameters));
            }
            //if(string.IsNullOrWhiteSpace(resourceParameters.SearchQuery)
            //    && string.IsNullOrWhiteSpace(resourceParameters.Tag))
            //{
            //    return await GetRestaurantsAsync();
            //}

            // collection to start from
            var collection = _dbContext.Restaurants as IQueryable<Restaurant>;

            //if (!string.IsNullOrWhiteSpace(resourceParameters.Tag))
            //{
            //    var tag = resourceParameters.Tag.Trim();

            //    collection = collection.Where(r => r.Tags.Contains(tag));
            //}


            if (!string.IsNullOrWhiteSpace(resourceParameters.SearchQuery) && 
                !string.IsNullOrWhiteSpace(resourceParameters.Tag))
            {
                var searchQuery = resourceParameters.SearchQuery.Trim();
                collection = collection.Where(r => r.Name.Contains(searchQuery))
                    .Union(collection.Where(r => r.Tags.Contains(searchQuery)));
            }

            if(!string.IsNullOrWhiteSpace(resourceParameters.SearchQuery) &&
                string.IsNullOrWhiteSpace(resourceParameters.Tag))
            {
                var searchQuery = resourceParameters.SearchQuery.Trim();
                collection = collection.Where(r => r.Name.Contains(searchQuery));
            }
            if(!string.IsNullOrWhiteSpace(resourceParameters.Tag) 
                && string.IsNullOrWhiteSpace(resourceParameters.SearchQuery))
            {
                var tag = resourceParameters.Tag.Trim();
                collection = collection.Where(r => r.Tags.Contains(tag));
            }
     

            if (!string.IsNullOrWhiteSpace(resourceParameters.OrderBy))
            {
                // get property mapping dictionary
                var authorPropertyMappingDictionary = _propertyMappingService
                    .GetPropertyMapping<RestaurantDto, Restaurant>();

                collection = collection.ApplySort(resourceParameters.OrderBy,
                    authorPropertyMappingDictionary);
            }

            return await PagedList<Restaurant>.CreateAsync(collection,
                        resourceParameters.PageNumber,
                        resourceParameters.PageSize);
            //return await collection
            //    .Skip(resourceParameters.PageSize* (resourceParameters.PageNumber-1))
            //    .Take(resourceParameters.PageSize)
            //    .ToListAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsAsync()
        {
            return await _dbContext.Restaurants.ToListAsync();
        }

        public async Task<bool> RestaurantExistsAsync(Guid restaurantId)
        {
            if (restaurantId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(restaurantId));
            }
            return await _dbContext.Restaurants.AnyAsync(r => r.RestaurantId == restaurantId);
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

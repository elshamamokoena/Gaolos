using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;

namespace Gaolos.Persistence.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(GaolosDbContext dbContext) : base(dbContext)
        {
        }

        //public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        //{
        //    var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
        //    return Task.FromResult(matches);
        //}
    }
}

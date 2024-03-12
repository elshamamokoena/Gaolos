using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(GaolosDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithRestaurants(bool includeHistory)
        {
            var allCategories = await _dbContext.Categories.Include(x => x.Restaurants).ToListAsync();
            return allCategories;

        }

        //public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        //{
        //    var allCategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
        //    if (!includePassedEvents)
        //    {
        //        allCategories.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date < DateTime.Today));
        //    }
        //    return allCategories;
        //}
    }
}

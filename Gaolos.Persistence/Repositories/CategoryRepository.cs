using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GaolosDbContext _dbContext;
        public CategoryRepository(GaolosDbContext dbContext) 
        {
            _dbContext = dbContext ?? 
                throw new ArgumentNullException(nameof(dbContext));
        }

        public void  AddCategory(Category category)
        {
            if(category == null) throw new ArgumentNullException(nameof(category));

            category.CategoryId = Guid.NewGuid();

            foreach(var restaurant in category.Restaurants)
            {
                restaurant.RestaurantId = Guid.NewGuid();
            }
            _dbContext.Categories.Add(category);

        }

        public async Task<bool> CategoryExistsAsync(Guid categoryId)
        {
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            return await _dbContext.Categories.AnyAsync(c=>c.CategoryId == categoryId);
        }

        public void DeleteCategory(Category category)
        {
            _dbContext.Categories.Remove(category);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync(IEnumerable<Guid> categoryIds)
        {
            if (categoryIds == null)
            {
                throw new ArgumentNullException(nameof(categoryIds));
            }

            return await _dbContext.Categories.Where(c => categoryIds.Contains(c.CategoryId))
                .OrderBy(a => a.Name)
                .ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesWithRestaurants(bool includeHistory)
        {
            var allCategories = await _dbContext.Categories.Include(x => x.Restaurants).ToListAsync();
            return allCategories;

        }

        public async Task<Category> GetCategoryAsync(Guid categoryId)
        {
            if (categoryId == Guid.Empty) throw new ArgumentNullException(nameof(categoryId));

        #pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId);
        #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<List<Category>> GetPagedCategories(int page, int size)
        {
            return await _dbContext.Categories
                .Skip((page-1)*size)
                .Take(size)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> GetTotalCountOfCategories()
        {
            return await _dbContext.Categories.CountAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return (await _dbContext.SaveChangesAsync() >= 0);
        }

        public void UpdateCategory(Category author)
        {
            //no code in implementation
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

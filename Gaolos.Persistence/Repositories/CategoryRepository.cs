using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Category;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities;
using Gaolos.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GaolosDbContext _dbContext;
        private IPropertyMappingService _propertyMappingService;
        public CategoryRepository(GaolosDbContext dbContext , IPropertyMappingService propertyMappingService) 
        {
            _dbContext = dbContext ?? 
                throw new ArgumentNullException(nameof(dbContext));
            _propertyMappingService = propertyMappingService ??               
                throw new ArgumentNullException(nameof(propertyMappingService));
        }

        public void  AddCategory(Category category)
        {
            if(category == null) throw new ArgumentNullException(nameof(category));

            category.CategoryId = Guid.NewGuid();

            foreach(var restaurant in category.Restaurants)
            {
                restaurant.RestaurantId = Guid.NewGuid();
            }
            //Check parent category exists later on

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

        public async Task<PagedList<Category>> GetCategoriesAsync(CategoryResourceParameters resourceParameters)
        {
            
            if(resourceParameters == null)
            {
                throw new ArgumentNullException(nameof(resourceParameters));
            }
            var collection = _dbContext.Categories as IQueryable<Category>;

            if(!string.IsNullOrWhiteSpace(resourceParameters.SearchQuery))
            {
                var searchQuery = resourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.Name.Contains(searchQuery));
            }
            if(!string.IsNullOrWhiteSpace(resourceParameters.OrderBy))
            {
                var categoryPropertyMappingDictionary = _propertyMappingService
                    .GetPropertyMapping<CategoryDto, Category>();
                collection = collection.ApplySort(resourceParameters.OrderBy,
                    categoryPropertyMappingDictionary);
            }
            return await PagedList<Category>.CreateAsync(collection,
                               resourceParameters.PageNumber,
                               resourceParameters.PageSize);

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

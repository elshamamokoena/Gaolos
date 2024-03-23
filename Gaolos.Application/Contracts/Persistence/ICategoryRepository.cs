using Gaolos.Domain.Entities;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface ICategoryRepository //: IAsyncRepository<Category>
    {
        //Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);

        Task <IEnumerable<Category>> GetCategoriesAsync ();
        Task<Category> GetCategoryAsync(Guid categoryId);
        Task<IEnumerable<Category>> GetCategoriesAsync(IEnumerable<Guid> categoryIds);
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category author);
        Task<bool> CategoryExistsAsync(Guid categoryId);
        Task<bool> SaveAsync();


        Task<List<Category>> GetCategoriesWithRestaurants(bool includeHistory);
        Task<List<Category>> GetPagedCategories(int page, int size);
        Task<int> GetTotalCountOfCategories();

    }
}

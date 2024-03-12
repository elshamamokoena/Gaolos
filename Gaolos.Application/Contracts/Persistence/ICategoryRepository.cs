using Gaolos.Domain.Entities;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        //Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
        Task<List<Category>> GetCategoriesWithRestaurants(bool includeHistory);
    }
}

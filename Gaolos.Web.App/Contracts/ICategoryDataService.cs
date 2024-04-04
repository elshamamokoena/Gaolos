using Gaolos.Web.App.Services;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryRestaurantsViewModel>> GetAllCategoriesWithRestaurants(bool includeHistory);
      //  Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}

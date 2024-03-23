using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class CategoriesCuisineGrid
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ICollection<CategoryRestaurantsViewModel> CategoriesWithRestaurants { get; set; }

        protected async override Task OnInitializedAsync()
        {
            CategoriesWithRestaurants = await CategoryDataService.GetAllCategoriesWithRestaurants(false);
        }

        protected void NavigateToCategory()
        {
            NavigationManager.NavigateTo($"/category");
        }
    }
}

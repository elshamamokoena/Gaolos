using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Category
{
    public partial class Categories
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryListViewModel CategoryList { get; set; } 
            = new CategoryListViewModel();

        private ICollection<CategoryViewModel > _categoryList { get; set; } 
            = new List<CategoryViewModel>();

        
    
        protected override async Task OnInitializedAsync()
        {
            CategoryList = await CategoryDataService.GetCategories();
            if (CategoryList.Categories != null)
                _categoryList = CategoryList.Categories;
        }

        public void NavigateToCategory(string name)
        {
            NavigationManager.NavigateTo($"/category/{name}");
        }
    }
}

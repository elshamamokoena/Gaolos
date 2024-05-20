using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Home
{
    public partial class CategoriesHome
    {
        [Inject]
        public ICategoryDataService categoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryListViewModel CategoryList { get; set; } 
           // = new CategoryListViewModel();
    
        protected override async Task OnInitializedAsync()
        {
            CategoryList = await categoryDataService.GetCategories(null,9,1,null,null);
            foreach (var category in CategoryList.Categories)
            {
                Console.WriteLine(category.ImageUrl);
            }
        }

        public void NavigateToCategory(string name)
        {
            NavigationManager.NavigateTo($"/category/{name}");
        }
    }
}

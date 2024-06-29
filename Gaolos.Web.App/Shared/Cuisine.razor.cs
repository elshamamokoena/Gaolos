using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Shared
{
    public partial class Cuisine
    {
        [Parameter]
        public int PageNumber{ get; set; }

        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private ICollection<CategoryViewModel> _categories { get; set; }
            = new List<CategoryViewModel>();

        private int _pageSize = 3;

        protected override async Task OnParametersSetAsync()
        {
            _categories = await GetCategories();
        }

        private async Task<List<CategoryViewModel>> GetCategories()
        {
            var pagedCategories = await CategoryDataService.GetCategories(null, _pageSize, PageNumber, null, null);
            if (pagedCategories.Categories != null)
                _categories = pagedCategories.Categories;

            return _categories.ToList();
        }
        private void NavigateToCategory(string name)
        {
            NavigationManager.NavigateTo($"/category/{name}");
        }
    }
}

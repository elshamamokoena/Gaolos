using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class PrimaryMenuCategories

    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ICollection<CategoryViewModel> Categories { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Categories = await CategoryDataService.GetAllCategories();
        }
    }
}

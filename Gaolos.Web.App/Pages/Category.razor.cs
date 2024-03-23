using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class Category
    {
        [Parameter]
        public string CategoryId { get; set; }
        private Guid SelectedCategoryId = Guid.Empty;

        [Parameter]
        public List<RestaurantNestedViewModel> Restaurants { get; set; }

        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        protected override async  Task OnInitializedAsync()
        {
            if(Guid.TryParse(CategoryId, out SelectedCategoryId))
            {
                
            }
        }



    }
}

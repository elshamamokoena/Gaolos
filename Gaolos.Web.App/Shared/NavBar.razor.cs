using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Gaolos.Web.App.Shared
{
    public partial class NavBar
    {
      
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        ICategoryDataService CategoryDataService { get; set; }
        [Inject]
        ILoggedInUserService loggedInUserService { get; set; }


        public CategoryListViewModel CategoryListViewModel { get; set; } 
            = new CategoryListViewModel();
    
        protected async override Task OnInitializedAsync()
        {
           // var user = await loggedInUserService.GetUserDetails();
        //   _categories = (await CategoryDataService.GetCategories(null, _pageSize, _pageNumber, null, null)).Categories;
        await GetCategories();

        }

        private async Task GetCategories()
        {
           CategoryListViewModel= await CategoryDataService.GetCategories(null, 3, 1, null, null);
           
        }
    }
}

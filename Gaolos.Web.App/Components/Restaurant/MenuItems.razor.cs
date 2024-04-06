using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuItems
    {
        [Parameter]

        public ICollection<MenuItemViewModel> MenuItemsList { get; set; } 
            = new List<MenuItemViewModel>();

        [Parameter]
        public EventCallback<MenuItemViewModel> OnMenuItemSelected { get; set; }
     
    }
}

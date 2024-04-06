using Gaolos.Web.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.Restaurant
{
    public partial class MenuItemQuickViewModal
    {
        [Parameter]
        public MenuItemViewModel? MenuItem { get; set; }
        private MenuItemViewModel? _menuItem;
        protected override void OnParametersSet()
        {
            _menuItem = MenuItem;
        }
        public void Close()
        {
            _menuItem = null;
        }
    }
}

using Gaolos.Web.App.Components.Cart;

namespace Gaolos.Web.App.Pages
{
    public partial class Cart
    {
        public Type Widget { get; set; } 

        protected override void OnInitialized()
        {
            Widget = typeof(Order);
        }

        public void SelectWidget(Type widget)
        {
            Widget = widget;
        }

    }
}

using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Pages
{
    public partial class OrderConfirmation
    {
        [Parameter]
        public Guid OrderId { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        private async Task TrackOrder()
        {
            NavigationManager.NavigateTo($"/track-order/{OrderId}");
        }
    }
}

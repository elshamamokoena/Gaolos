using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components
{
    public partial class IncrementalPager
    {
        [Parameter]
        public int PageIndex { get; set; }

        [Parameter]
        public int TotalPages { get; set; }

        [Parameter]
        public bool HasPreviousPage { get; set; }

        [Parameter]
        public bool HasNextPage { get; set; }

        [Parameter]
        public int Increment { get; set; }
        [Parameter]
        public int TotalItems { get; set; }

        [Parameter]
        public EventCallback OnClick { get; set; }

        private int _progress = 0;

        protected override void OnParametersSet()
        {
            _progress = (int)(((double)PageIndex / TotalPages) * 100);
        }
    }
}

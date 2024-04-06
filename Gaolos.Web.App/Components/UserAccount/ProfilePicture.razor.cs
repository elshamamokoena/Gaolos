using Microsoft.AspNetCore.Components;

namespace Gaolos.Web.App.Components.UserAccount
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}

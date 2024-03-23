using System;

namespace Gaolos.Web.App.ViewModels
{
    public class RestaurantNestedViewModel
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}

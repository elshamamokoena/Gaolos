using System.ComponentModel.DataAnnotations;

namespace Gaolos.Web.App.ViewModels.Basket
{
    public class CouponViewModel
    {

        public Guid? CouponId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage ="Coupon code is too long")]
        public string Code { get; set; }= "AlmostFree";
    }
}

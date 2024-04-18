using Gaolos.Application.Models.Discount;
using Gaolos.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Discount.Commands.UseCouponCommand
{
    public class UseCouponCommandResponse:BaseResponse
    {
        public UseCouponCommandResponse():base()
        {

        }

        //public UseCouponCommandResponse(Guid correlationId):base(correlationId)
        //{

        //}

    //    public bool IsUsed { get; set; }
        public CouponVm coupon { get; set; }= default!;
    }
}

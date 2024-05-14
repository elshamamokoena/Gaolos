using Gaolos.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod
{
    public class CreatePaymentMethodCommandResponse:BaseResponse
    {
        public CreatePaymentMethodCommandResponse():base()
        {

        }

        public CreatedPaymentMethodVm PaymentMethod { get; set; }
    }
}

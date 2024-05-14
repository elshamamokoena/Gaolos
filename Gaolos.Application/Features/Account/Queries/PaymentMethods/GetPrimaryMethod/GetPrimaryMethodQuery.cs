using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPrimaryMethod
{
    public class GetPrimaryMethodQuery:IRequest<PaymentMethodVm>
    {
        public Guid UserId { get; set; }
    }
}

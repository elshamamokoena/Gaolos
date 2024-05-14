using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethods
{
    public class GetPaymentMethodsQuery:IRequest<IEnumerable<CreditCardsVm>>
    {
        public Guid UserId { get; set; }

    }
}

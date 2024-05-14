using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.DeletePaymentMethod
{
    public class DeletePaymentMethodCommand: IRequest
    {
        public Guid CreditCardId { get; set; }
        public Guid UserId { get; set; }
    }
}

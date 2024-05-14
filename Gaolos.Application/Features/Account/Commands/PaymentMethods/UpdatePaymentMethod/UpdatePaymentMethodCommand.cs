using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.UpdatePaymentMethod
{
    public class UpdatePaymentMethodCommand:IRequest
    {
        //public string CardNumber { get; set; }
        public Guid CreditCardId { get; set; }
        public Guid UserId { get; set; }


        public string Expiry { get; set; }
        public string CVV { get; set; }
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; } = true;
    }
}

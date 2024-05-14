using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod
{
    public class PaymentMethodForCreationDto
    {
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CVV { get; set; }
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; } = false;
    }
}

using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.UserAccount
{
    public class CreditCard:AuditableEntity
    {
        public Guid CreditCardId { get; set; }

        public Guid UserId { get; set; }


        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CVV { get; set; }
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; } = true;
        public string CardType { get; set; }= "Visa";
        public string CreditCardNumber()
        {
            return "ending in " + CardNumber.Substring(12, 4);
        }
    }
}

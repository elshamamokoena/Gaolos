using Gaolos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Domain.Entities.UserAccount
{
    public class DeliveryAddress:AuditableEntity
    {
        public Guid DeliveryAddressId { get; set; }

        public Guid UserId { get; set; }

        public string Street { get; set; }
        public string Suburb { get; set; }
        public string ? Complex { get; set; }
        public string City { get; set; }
        public string ?Province { get; set; }
        public string ZipCode { get; set; }
        public bool isPrimary { get; set; }
    }
}

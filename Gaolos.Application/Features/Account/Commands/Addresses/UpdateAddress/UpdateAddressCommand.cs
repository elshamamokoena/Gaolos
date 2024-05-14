using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.Addresses.UpdateAddress
{
    public class UpdateAddressCommand:IRequest
    {
        public Guid DeliveryAddressId { get; set; }

        public Guid UserId { get; set; }

        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public bool isPrimary { get; set; }
    }
}

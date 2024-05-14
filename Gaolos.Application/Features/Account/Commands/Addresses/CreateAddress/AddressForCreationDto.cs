using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.Addresses.CreateAddress
{
    public class AddressForCreationDto
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Complex { get; set; }
        public string City { get; set; }
        public string? Province { get; set; }
        public string ZipCode { get; set; }
        public bool isPrimary { get; set; }
    }
}

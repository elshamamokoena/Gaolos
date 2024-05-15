﻿namespace Gaolos.Application.Features.Account.Commands.Addresses.CreateAddress
{
    public class CreatedAddressVm
    {
        public Guid DeliveryAddressId { get; set; }

        public Guid UserId { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Complex { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public bool isPrimary { get; set; }
    }
}
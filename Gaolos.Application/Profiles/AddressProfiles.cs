using AutoMapper;
using Gaolos.Application.Features.Account.Commands.Addresses.CreateAddress;
using Gaolos.Application.Features.Account.Commands.Addresses.UpdateAddress;
using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using Gaolos.Domain.Entities.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Profiles
{
    public class AddressProfiles:Profile
    {
        public AddressProfiles()
        {
            CreateMap<CreateAddressCommand, AddressForCreationDto>().ReverseMap();
            CreateMap<UpdateAddressCommand, AddressForUpdateDto>().ReverseMap();
            //  CreateMap<CreateAddressCommandResponse, CreatedAddressVm>();

            CreateMap<DeliveryAddress, UserAddressVm>().ReverseMap();
            CreateMap<DeliveryAddress, UpdateAddressCommand>().ReverseMap();
            CreateMap<DeliveryAddress, CreatedAddressVm>().ReverseMap();
            CreateMap<CreateAddressCommand, DeliveryAddress>().ReverseMap();
        }
    }
}

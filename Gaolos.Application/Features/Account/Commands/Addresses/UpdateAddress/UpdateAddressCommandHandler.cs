using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities.UserAccount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.Addresses.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public UpdateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToUpdate = await _addressRepository.GetAddressAsync(request.UserId, request.DeliveryAddressId);
            _mapper.Map(request, addressToUpdate, typeof(UpdateAddressCommand), typeof(DeliveryAddress));
            _addressRepository.UpdateAddress(addressToUpdate);
            await _addressRepository.SaveAsync();
        }
    }
}

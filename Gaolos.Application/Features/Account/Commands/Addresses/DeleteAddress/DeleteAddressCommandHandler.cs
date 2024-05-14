using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Domain.Entities.UserAccount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Commands.Addresses.DeleteAddress
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
    {
        private readonly IAddressRepository _addressRepository;
        public DeleteAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            if(!await _addressRepository.AddressExistsAsync(request.DeliveryAddressId))
            {
                throw new NotFoundException(nameof(DeliveryAddress), request.DeliveryAddressId);
            }
            var addressToDelete = await _addressRepository.GetAddressAsync(request.UserId,request.DeliveryAddressId);
            _addressRepository.DeleteAddress(addressToDelete);
            await _addressRepository.SaveAsync();
        }
    }

}

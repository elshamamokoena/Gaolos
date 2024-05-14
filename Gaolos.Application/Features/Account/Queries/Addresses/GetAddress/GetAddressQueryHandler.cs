using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using Gaolos.Domain.Entities.UserAccount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetAddress
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, UserAddressVm>
    {

        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public GetAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<UserAddressVm> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            if(!await _addressRepository.AddressExistsAsync(request.DeliveryAddressId))
            {
                throw new NotFoundException(nameof(DeliveryAddress), request.DeliveryAddressId);
            }   
            var address = await _addressRepository.GetAddressAsync(request.UserId, request.DeliveryAddressId);
            return _mapper.Map<UserAddressVm>(address);
        }
    }
}

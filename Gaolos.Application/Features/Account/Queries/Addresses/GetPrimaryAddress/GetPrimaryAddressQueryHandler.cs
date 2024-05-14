using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetPrimaryAddress
{
    public class GetPrimaryAddressQueryHandler : IRequestHandler<GetPrimaryAddressQuery, UserAddressVm>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetPrimaryAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<UserAddressVm> Handle(GetPrimaryAddressQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetPrimaryAddressAsync(request.UserId);

            return _mapper.Map<UserAddressVm>(address);
        }
    }
}

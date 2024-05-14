using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Account.Queries.Addresses.GetAddresses
{
    public class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, IEnumerable<UserAddressVm>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public GetAddressesQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserAddressVm>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAddressesForUserAsync(request.UserId);
            return _mapper.Map<IEnumerable<UserAddressVm>>(addresses);

        }
    }

}

using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities.UserAccount;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly GaolosDbContext _context;
        public AddressRepository(GaolosDbContext context)
        {
            _context = context;
        }
        public void AddAddress(DeliveryAddress address)
        {
            _context.Addresses.Add(address);
        }

        public async Task<bool> AddressExistsAsync(Guid addressId)
        {
            if(addressId == Guid.Empty) throw new ArgumentNullException(nameof(addressId));

            return await _context.Addresses.AnyAsync(a => a.DeliveryAddressId == addressId);
        }

        public void DeleteAddress(DeliveryAddress address)
        {
            _context.Addresses.Remove(address);
        }

        public async Task<DeliveryAddress> GetAddressAsync(Guid userId,Guid addressId)
        {
            if(userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            if(addressId == Guid.Empty) throw new ArgumentNullException(nameof(addressId));

            #pragma warning disable CS8603 // Possible null reference return.
            return await _context.Addresses
                .FirstOrDefaultAsync(a => a.UserId == userId && a.DeliveryAddressId == addressId );
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<DeliveryAddress>> GetAddressesForUserAsync(Guid userId)
        {
            if(userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            return await _context.Addresses
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }

        public Task<DeliveryAddress> GetPrimaryAddressAsync(Guid userId)
        {
            if(userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));

        #pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
            return _context.Addresses
                .FirstOrDefaultAsync(a => a.UserId == userId && a.isPrimary);
        #pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void UpdateAddress(DeliveryAddress address)
        {

            if(address == null) throw new ArgumentNullException(nameof(address));

            if(address.isPrimary)
            {
               _context.Addresses
                    .Where(a => a.UserId == address.UserId && a.DeliveryAddressId!=address.DeliveryAddressId)
                    .ToList()
                    .ForEach(a => a.isPrimary = false);
            }
            // update with the Command Handler
        }
    }
}

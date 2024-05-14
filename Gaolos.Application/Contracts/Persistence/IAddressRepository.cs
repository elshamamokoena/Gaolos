using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IAddressRepository
    {
        Task<IEnumerable<DeliveryAddress>> GetAddressesForUserAsync(Guid userId);
        Task<DeliveryAddress> GetAddressAsync(Guid userId,Guid addressId);
        Task<DeliveryAddress> GetPrimaryAddressAsync(Guid userId);
        void AddAddress(DeliveryAddress address);
        void  UpdateAddress(DeliveryAddress address);
        void DeleteAddress(DeliveryAddress address);
        Task<bool> AddressExistsAsync(Guid addressId);
        Task<bool> SaveAsync();
    }
}

using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IOrderRepository //: IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersForUser(Guid userId);
        Task AddOrder(Order order);
        Task<Order> GetOrderById(Guid orderId);
        Task UpdateOrderPaymentStatus(Guid orderId, bool paid);
        Task<bool> SaveAsync();
    }
}

using Gaolos.Application.Helpers;
using Gaolos.Application.ResourceParameters;
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
        Task<PagedList<Order>> GetOrdersForUser(Guid userId, OrderResourceParameters resourceParameters);
        Task AddOrder(Order order);
        Task<Order> GetOrderById(Guid userId, Guid orderId);
        Task<Order> GetOrder(Guid orderId);
        Task UpdateOrderPaymentStatus(Guid orderId, bool paid);
        Task<bool> SaveAsync();
    }
}

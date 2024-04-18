using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class OrderRepository :IOrderRepository//: BaseRepository<Order>, IOrderRepository
    {
        private readonly GaolosDbContext _dbContext;
        public OrderRepository(GaolosDbContext dbContext)
        {
            _dbContext = dbContext
                ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task AddOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            order.OrderId = Guid.NewGuid();
            foreach (var item in order.OrderLines)
            {
                item.OrderLineId = Guid.NewGuid();
            }
            await _dbContext.Orders.AddAsync(order);
        }

        public async Task<Order> GetOrderById(Guid orderId)
        {
            if (orderId == Guid.Empty) throw new ArgumentNullException(nameof(orderId));

#pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Orders
                .Include(x => x.OrderLines)
                .FirstOrDefaultAsync(x => x.OrderId == orderId);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Order>> GetOrdersForUser(Guid userId)
        {
            if(userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            return await _dbContext.Orders
                .Where(x => x.UserId == userId)
                .Include(x => x.OrderLines)
                .ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return (await _dbContext.SaveChangesAsync() > 0);
        }

        public Task UpdateOrderPaymentStatus(Guid orderId, bool paid)
        {
            throw new NotImplementedException();
        }







        //public OrderRepository(GaolosDbContext dbContext) : base(dbContext)
        //{
        //}

        //public async Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size)
        //{
        //    return await _dbContext.Orders.Where(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year)
        //        .Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        //}

        //public async Task<int> GetTotalCountOfOrdersForMonth(DateTime date)
        //{
        //    return await _dbContext.Orders.CountAsync(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year);
        //}
    }
}

using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Order;
using Gaolos.Application.ResourceParameters;
using Gaolos.Domain.Entities;
using Gaolos.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Persistence.Repositories
{
    public class OrderRepository :IOrderRepository//: BaseRepository<Order>, IOrderRepository
    {
        private readonly GaolosDbContext _dbContext;
        private readonly IPropertyMappingService _propertyMappingService;

        public OrderRepository(GaolosDbContext dbContext, IPropertyMappingService propertyMappingService)
        {
            _dbContext = dbContext
                ?? throw new ArgumentNullException(nameof(dbContext));
            _propertyMappingService = propertyMappingService;
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

        public async Task<Order> GetOrderById(Guid userId, Guid orderId)
        {
            if (orderId == Guid.Empty) throw new ArgumentNullException(nameof(orderId));
            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));

#pragma warning disable CS8603 // Possible null reference return.
            return await _dbContext.Orders
                .Where(x => x.UserId == userId && x.OrderId == orderId)
                .Include(x => x.OrderLines)
                .ThenInclude(x => x.MenuItem)
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<PagedList<Order>> GetOrdersForUser(Guid userId, OrderResourceParameters resourceParameters)
        {

            if (resourceParameters == null) throw new ArgumentNullException(nameof(resourceParameters));

            var collection = _dbContext.Orders as IQueryable<Order>;

            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));

            collection = collection.Where(x => x.UserId == userId)
                .Include(x=>x.OrderLines);

            if (!string.IsNullOrWhiteSpace(resourceParameters.SearchQuery))
            {
                var searchQuery = resourceParameters.SearchQuery.Trim();
                collection = collection.Where(x => x.Name.Contains(searchQuery));
            }

            if(resourceParameters.OrderStatus.HasValue)
            {
                collection = collection
                    .Where(x => x.OrderStatus == resourceParameters.OrderStatus);
            }

            if (!string.IsNullOrWhiteSpace(resourceParameters.OrderBy))
            {
                var orderPropertyMapping = _propertyMappingService
                    .GetPropertyMapping<OrderDto, Order>();

                collection = collection
                    .ApplySort(resourceParameters.OrderBy, orderPropertyMapping);
            }

            return await PagedList<Order>
                .CreateAsync(collection,
                resourceParameters.PageNumber,
                resourceParameters.PageSize);

            //if(userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            //return await _dbContext.Orders
            //    .Where(x => x.UserId == userId)
            //    .Include(x => x.OrderLines)
            //    .ToListAsync();
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

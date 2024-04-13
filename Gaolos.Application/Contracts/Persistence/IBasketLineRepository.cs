using Gaolos.Domain.Entities.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IBasketLineRepository
    {
        Task<IEnumerable<BasketLine>> GetBasketLinesAsync(Guid basketId);
        Task<BasketLine> GetBasketLineAsync(Guid basketLineId);
        Task<BasketLine> AddOrUpdateBasketLine(Guid BasketId,BasketLine basketLine);
        void UpdateBasketLine(BasketLine basketLine);
        void RemoveBasketLine(BasketLine basketLine);
        Task<bool> SaveAsync();

    }
}

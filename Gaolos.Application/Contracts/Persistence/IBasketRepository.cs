using Gaolos.Domain.Entities.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketAsync(Guid basketId);
        void AddBasket(Basket basket);
        Task ClearBasket(Guid basketId);
        Task<bool> SaveAsync();
        Task<bool> BasketExistsAsync(Guid basketId);

    }
}

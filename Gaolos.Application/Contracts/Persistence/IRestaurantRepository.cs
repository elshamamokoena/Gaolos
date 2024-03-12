using Gaolos.Domain.Entities;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IRestaurantRepository : IAsyncRepository<Restaurant>
    {
        //Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}

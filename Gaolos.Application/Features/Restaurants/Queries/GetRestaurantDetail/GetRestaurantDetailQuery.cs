using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQuery : IRequest<RestaurantDetailVm>
    {
        public Guid RestaurantId { get; set; }
        public string? Fields { get; set; }
    }
}

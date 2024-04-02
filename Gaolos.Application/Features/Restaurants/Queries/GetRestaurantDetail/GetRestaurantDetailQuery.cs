using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQuery : IRequest<RestaurantDetailDto>
    {
        public Guid RestaurantId { get; set; }
        public string? Fields { get; set; }
    }
}

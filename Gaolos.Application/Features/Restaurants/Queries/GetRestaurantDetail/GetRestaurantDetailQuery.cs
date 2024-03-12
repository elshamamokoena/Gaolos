using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQuery : IRequest<RestaurantDetailVm>
    {
        public Guid Id { get; set; }
    }
}

using MediatR;

namespace Gaolos.Application.Features.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantCommand : IRequest
    {
        public Guid RestaurantId { get; set; }
    }
}

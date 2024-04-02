using MediatR;

namespace Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"Restaurant name: {Name};";
        }
    }
}

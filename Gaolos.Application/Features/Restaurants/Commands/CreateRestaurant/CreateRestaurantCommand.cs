using MediatR;

namespace Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public override string ToString()
        {
            return $"Restaurant name: {Name};";
        }
    }
}

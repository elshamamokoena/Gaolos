using MediatR;
using System;

namespace Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommand : IRequest
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}

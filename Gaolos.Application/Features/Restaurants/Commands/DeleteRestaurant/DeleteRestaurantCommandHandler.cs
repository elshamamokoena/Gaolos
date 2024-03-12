using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand>
    {
        private readonly IAsyncRepository<Restaurant> _restaurantRepository;
        private readonly IMapper _mapper;

        public DeleteRestaurantCommandHandler(IMapper mapper, IAsyncRepository<Restaurant> restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurantToDelete = await _restaurantRepository.GetByIdAsync(request.RestaurantId);

            await _restaurantRepository.DeleteAsync(restaurantToDelete);
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand>
    {
        private readonly IAsyncRepository<Restaurant> _restaurantRepository;
        private readonly IMapper _mapper;

        public UpdateRestaurantCommandHandler(IMapper mapper, IAsyncRepository<Restaurant> restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {

            var restaurantToUpdate = await _restaurantRepository.GetByIdAsync(request.RestaurantId);

            _mapper.Map(request, restaurantToUpdate, typeof(UpdateRestaurantCommand), typeof(Restaurant));

            await _restaurantRepository.UpdateAsync(restaurantToUpdate);
        }
    }
}
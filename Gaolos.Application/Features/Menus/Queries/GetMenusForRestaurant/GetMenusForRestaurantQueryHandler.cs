using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant
{
    public class GetMenusForRestaurantQueryHandler : IRequestHandler<GetMenusForRestaurantQuery, IEnumerable<MenuForRestaurantVm>>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;

        public GetMenusForRestaurantQueryHandler(IMenuRepository menuRepository, 
            IMapper mapper, 
            IRestaurantRepository restaurantRepository)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<IEnumerable<MenuForRestaurantVm>> Handle(GetMenusForRestaurantQuery request, CancellationToken cancellationToken)
        {
            if(! await _restaurantRepository.RestaurantExistsAsync(request.RestaurantId))
            {                 
                throw new NotFoundException(nameof(request.RestaurantId), request.RestaurantId);
            }    

            var menus = await _menuRepository.GetMenusAsync(request.RestaurantId);
            return _mapper.Map<IEnumerable<MenuForRestaurantVm>>(menus);
        }
    }
}

using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Menus.Queries.GetMenuForRestaurant
{
    public class GetMenuForRestaurantQueryHandler : IRequestHandler<GetMenuForRestaurantQuery, MenuForRestaurantVm>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;

        public GetMenuForRestaurantQueryHandler(IMenuRepository menuRepository, IMapper mapper, 
            IRestaurantRepository restaurantRepository)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<MenuForRestaurantVm> Handle(GetMenuForRestaurantQuery request, CancellationToken cancellationToken)
        {
            if(! await _restaurantRepository.RestaurantExistsAsync(request.RestaurantId))
            {
                throw new NotFoundException(nameof(request.RestaurantId), request.RestaurantId);
            }
            var menu = await _menuRepository.GetMenuAsync(request.RestaurantId, request.MenuId);

            if(menu == null)
            {
                throw new NotFoundException(nameof(MenuForRestaurantVm), request.MenuId);
            }   

            return _mapper.Map<MenuForRestaurantVm>(menu);

        }
    }
}

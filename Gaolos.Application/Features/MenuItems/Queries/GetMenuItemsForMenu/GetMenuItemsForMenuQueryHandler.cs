using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Exceptions;
using Gaolos.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu
{
    public class GetMenuItemsForMenuQueryHandler : IRequestHandler<GetMenuItemsForMenuQuery, IEnumerable<MenuItemsForMenuDto>>
    {
        private readonly IMenuItemsRepository _menuItemsRepository;
        private readonly IMapper _mapper;
        private readonly IMenuRepository _menuRepository;

        public GetMenuItemsForMenuQueryHandler(IMenuItemsRepository menuItemsRepository,
            IMapper mapper, IMenuRepository menuRepository)
        {
            _menuItemsRepository = menuItemsRepository;
            _mapper = mapper;
            _menuRepository = menuRepository;
        }
        public async Task<IEnumerable<MenuItemsForMenuDto>> Handle(GetMenuItemsForMenuQuery request, CancellationToken cancellationToken)
        {
            if (!await _menuRepository.MenuExistsAsync(request.MenuId))
            {
                throw new NotFoundException(nameof(Menu), request.MenuId);
            }
            var menuItems = await _menuItemsRepository.GetMenuItemsAsync(request.MenuId);
            return _mapper.Map<IEnumerable<MenuItemsForMenuDto>>(menuItems);
        }
    }
}

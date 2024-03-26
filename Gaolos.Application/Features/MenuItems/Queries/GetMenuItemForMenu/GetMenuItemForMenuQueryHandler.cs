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

namespace Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu
{
    public class GetMenuItemForMenuQueryHandler : IRequestHandler<GetMenuItemForMenuQuery, MenuItemForMenuDto>
    {
        private readonly IMenuItemsRepository _menuItemRepository;
        private readonly IMapper _mapper;
        private readonly IMenuRepository _menuRepository;

        public GetMenuItemForMenuQueryHandler(IMenuItemsRepository menuItemRepository, 
            IMapper mapper, IMenuRepository menuRepository)
        {
            _menuItemRepository = menuItemRepository;
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public async Task<MenuItemForMenuDto> Handle(GetMenuItemForMenuQuery request, CancellationToken cancellationToken)
        {
            if (!await _menuRepository.MenuExistsAsync(request.MenuId))
            {
                throw new NotFoundException(nameof(Menu), request.MenuId);
            }
            var menuItem = await _menuItemRepository.GetMenuItemAsync(request.MenuId, request.MenuItemId);

            if (menuItem == null)
            {
                throw new NotFoundException(nameof(MenuItem), request.MenuItemId);
            }

            return _mapper.Map<MenuItemForMenuDto>(menuItem);
        }
    }
}

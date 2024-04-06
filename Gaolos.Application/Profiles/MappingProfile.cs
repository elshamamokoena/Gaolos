using AutoMapper;
using Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesList;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants;
using Gaolos.Application.Features.Categories.Queries.GetCategory;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu;
using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Restaurant;
using Gaolos.Domain.Entities;

namespace Gaolos.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantDetailVm>().ReverseMap();
            CreateMap<Restaurant, RestaurantListVm>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryDetailDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryRestaurantListVm>();

            CreateMap<Restaurant, CreateRestaurantCommand>().ReverseMap();
            CreateMap<Restaurant, UpdateRestaurantCommand>().ReverseMap();
            CreateMap<Restaurant, CategoryRestaurantDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantsForCategoryDto>().ReverseMap();


            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryWithParentCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryWithParentCategoryDto>().ReverseMap();

            CreateMap<Restaurant, RestaurantExportDto>().ReverseMap();

            CreateMap<Menu,MenuForRestaurantVm>().ReverseMap();

            CreateMap<MenuItem,MenuItemForMenuDto>().ReverseMap();
            CreateMap<MenuItem, MenuItemsForMenuVm>().ReverseMap();
            CreateMap(typeof(PagedList<>), typeof(PagedListDto<>)).ConvertUsing(typeof(Helpers.Converter<,>));
        }
    }
}

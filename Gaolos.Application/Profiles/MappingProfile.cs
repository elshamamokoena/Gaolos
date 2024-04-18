using AutoMapper;
using Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesList;
using Gaolos.Application.Features.Categories.Queries.GetCategoriesListWithRestaurants;
using Gaolos.Application.Features.Categories.Queries.GetCategory;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemForMenu;
using Gaolos.Application.Features.MenuItems.Queries.GetMenuItemsForMenu;
using Gaolos.Application.Features.Menus.Queries.GetMenusForRestaurant;
using Gaolos.Application.Features.Orders.Queries.GetOrdersForUser;
using Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant;
using Gaolos.Application.Features.Restaurants.Commands.UpdateRestaurant;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantDetail;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsList;
using Gaolos.Application.Features.ShoppingBasket.Commands.Checkout;
using Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket;
using Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Commands.UpdateBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasket;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLine;
using Gaolos.Application.Features.ShoppingBasket.Queries.GetBasketLines;
using Gaolos.Application.Helpers;
using Gaolos.Application.Models.Discount;
using Gaolos.Application.Models.Restaurant;
using Gaolos.Domain.Entities;
using Gaolos.Domain.Entities.Discount;
using Gaolos.Domain.Entities.ShoppingCart;

namespace Gaolos.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CheckoutCommand, Order>().ReverseMap();
            CreateMap<OrderForUserVm, Order>().ReverseMap();
            CreateMap<OrderLine, BasketLine>().ReverseMap();

            CreateMap<CreateBasketLineDto, BasketLine>().ReverseMap();
            CreateMap<UpdateBasketLineDto, BasketLine>().ReverseMap();
            CreateMap<UpdateBasketLineCommand, BasketLine>().ReverseMap();
            CreateMap<CreateBasketLineCommand, BasketLine>().ReverseMap();

            CreateMap<MenuItem, MenuItemDto>().ReverseMap();

            CreateMap<BasketLine, BasketLineVm>().ReverseMap();
            CreateMap<BasketLine, BasketLinesVm>().ReverseMap();

            CreateMap<OrderLine,OrderLineDto>().ReverseMap();
            CreateMap<Order, OrderVm>().ReverseMap();

            CreateMap<Coupon, CouponVm>().ReverseMap();
            CreateMap<CreateBasketCommand, Basket>();
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
            CreateMap<Basket, BasketVm>().ReverseMap();

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

using AutoMapper;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;
using Gaolos.Web.App.ViewModels.Basket;
using System.Dynamic;

namespace Gaolos.Web.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {

            ////Vms are coming in from the API, ViewModel are the local entities in Blazor
            ///

            //account
            //Addresses
            CreateMap<DeliveryAddressViewModel, AddressForUpdateDto>().ReverseMap();
            CreateMap<DeliveryAddressViewModel, AddressForCreationDto>().ReverseMap();
            CreateMap<DeliveryAddressViewModel, UserAddressVm>().ReverseMap();

            //PaymentMethods
            CreateMap<PaymentMethodViewModel, PaymentMethodForCreationDto>().ReverseMap();
            CreateMap<PaymentMethodViewModel, PaymentMethodForUpdateDto>().ReverseMap();
            CreateMap<PaymentMethodViewModel, PaymentMethodVm>().ReverseMap();
            CreateMap<PaymentMethodViewModel, CreditCardsVm>().ReverseMap();

            //Orders
            CreateMap<OrderViewModel, OrderForUserVm>().ReverseMap();
            CreateMap<OrderViewModel, DetailedOrderForUserVm>().ReverseMap();
            CreateMap<OrderViewModel, OrderVm>().ReverseMap();
            CreateMap<PagedOrdersViewModel, PagedOrdersVm>().ReverseMap();
            CreateMap<CheckoutCommand, CheckoutViewModel>().ReverseMap();
            CreateMap<OrderLineViewModel, OrderLineDto>().ReverseMap();
            //Basket
            CreateMap<BasketViewModel, BasketVm>().ReverseMap();
            CreateMap<BasketLineViewModel, BasketLineVm>().ReverseMap();
            CreateMap<BasketLinesVm, BasketLineViewModel>().ReverseMap();
            CreateMap<CreatedBasketVm, BasketViewModel>().ReverseMap();
            CreateMap<CreatedBasketLineVm, BasketLineViewModel>().ReverseMap();
            

            CreateMap<CategoryListVm, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryListViewModel, PagedCategoriesVm>().ReverseMap();


            CreateMap<RestaurantListVm, RestaurantViewModel >().ReverseMap();
            CreateMap<RestaurantListViewModel, PagedRestaurantsVm>().ReverseMap();
           CreateMap<RestaurantDetailVm, RestaurantViewModel>().ReverseMap();

            CreateMap<MenuForRestaurantVm, MenuViewModel>().ReverseMap();
            CreateMap<MenuItemsForMenuVm, MenuItemViewModel>().ReverseMap();

            //CreateMap<RestaurantDetailViewModel, CreateRestaurantCommand>().ReverseMap();
            //CreateMap<RestaurantDetailViewModel, UpdateRestaurantCommand>().ReverseMap();

            //CreateMap<CategoryRestaurantDto, RestaurantNestedViewModel>().ReverseMap();

            //CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
            //CreateMap<CategoryRestaurantListVm, CategoryRestaurantsViewModel>().ReverseMap();
            //CreateMap<CreateCategoryCommand, CategoryViewModel>().ReverseMap();
            //CreateMap<CreateCategoryDto, CategoryDto>().ReverseMap();

            //CreateMap<PagedCategoriesVm, PagedCategoriesViewModel>().ReverseMap();
            //CreateMap<PagedCategoryDto, CategoryViewModel>().ReverseMap();
        }
    }
}

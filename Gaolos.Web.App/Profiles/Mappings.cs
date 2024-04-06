using AutoMapper;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels;
using System.Dynamic;

namespace Gaolos.Web.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {

            ////Vms are coming in from the API, ViewModel are the local entities in Blazor
            ///

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

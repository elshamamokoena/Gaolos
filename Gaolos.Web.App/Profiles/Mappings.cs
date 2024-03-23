using AutoMapper;
using Gaolos.Web.App.Services;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            //Vms are coming in from the API, ViewModel are the local entities in Blazor
            CreateMap<RestaurantListVm, RestaurantListViewModel>().ReverseMap();
            CreateMap<RestaurantDetailVm, RestaurantDetailViewModel>().ReverseMap();

            CreateMap<RestaurantDetailViewModel, CreateRestaurantCommand>().ReverseMap();
            CreateMap<RestaurantDetailViewModel, UpdateRestaurantCommand>().ReverseMap();

            CreateMap<CategoryRestaurantDto, RestaurantNestedViewModel>().ReverseMap();

            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryListVm, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryRestaurantListVm, CategoryRestaurantsViewModel>().ReverseMap();
            CreateMap<CreateCategoryCommand, CategoryViewModel>().ReverseMap();
            CreateMap<CreateCategoryDto, CategoryDto>().ReverseMap();

            CreateMap<PagedCategoriesVm, PagedCategoriesViewModel>().ReverseMap();
            CreateMap<PagedCategoryDto, CategoryViewModel>().ReverseMap();
        }
    }
}

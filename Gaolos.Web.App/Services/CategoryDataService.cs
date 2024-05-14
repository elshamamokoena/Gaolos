using AutoMapper;
using Blazored.LocalStorage;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;

namespace Gaolos.Web.App.Services
{
    public class CategoryDataService : BaseDataService, ICategoryDataService
    {
        private readonly IMapper _mapper;

        public CategoryDataService(IClient client, IMapper mapper, ILocalStorageService localStorage): base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<CategoryListViewModel> GetCategories()
        {
            throw new NotImplementedException();

        }

        public async Task<CategoryListViewModel> GetCategories(string ? searchQuery,int? pageSize,  int ? pageNumber,
            string? orderBy, string? fields)
        {
            var categories = await _client.GetCategoriesAsync(orderBy, searchQuery,pageNumber, pageSize,fields );
            var mappedCategories = _mapper.Map<CategoryListViewModel>(categories);
            return mappedCategories;
        }

        //public async Task<List<CategoryViewModel>> GetAllCategories()
        //{
        //    var allCategories = await _client.GetAllCategoriesAsync();
        //    var mappedCategories = _mapper.Map<ICollection<CategoryViewModel>>(allCategories);
        //    return mappedCategories.ToList();

        //}

        //public async Task<List<CategoryRestaurantsViewModel>> GetAllCategoriesWithRestaurants(bool includeHistory)
        //{
        //    var allCategories = await _client.GetCategoriesWithRestaurantsAsync(includeHistory);
        //    var mappedCategories = _mapper.Map<ICollection<CategoryRestaurantsViewModel>>(allCategories);
        //    return mappedCategories.ToList();
        //}

        //public async Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel)
        //{
        //    try
        //    {
        //        ApiResponse<CategoryDto> apiResponse = new ApiResponse<CategoryDto>();
        //        CreateCategoryCommand createCategoryCommand = _mapper.Map<CreateCategoryCommand>(categoryViewModel);
        //        var createCategoryCommandResponse = await _client.AddCategoryAsync(createCategoryCommand);
        //        if (createCategoryCommandResponse.Success)
        //        {
        //            apiResponse.Data = _mapper.Map<CategoryDto>(createCategoryCommandResponse.Category);
        //            apiResponse.Success = true;
        //        }
        //        else
        //        {
        //            apiResponse.Data = null;
        //            foreach (var error in createCategoryCommandResponse.ValidationErrors)
        //            {
        //                apiResponse.ValidationErrors += error + Environment.NewLine;
        //            }
        //        }
        //        return apiResponse;
        //    }
        //    catch (ApiException ex)
        //    {
        //        return ConvertApiExceptions<CategoryDto>(ex);
        //    }
        //}
    }
}
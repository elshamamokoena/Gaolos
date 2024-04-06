using AutoMapper;
using Blazored.LocalStorage;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;
using System.Dynamic;

namespace Gaolos.Web.App.Services
{
    public class RestaurantDataService: BaseDataService , IRestaurantDataService
    {
        
        private readonly IMapper _mapper;

        public RestaurantDataService(IClient client, IMapper mapper, 
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async  Task<RestaurantViewModel> GetRestaurant(Guid restaurantId, string? fields, string? accept)
        {
          //  throw new NotImplementedException();
          var restaurant = await _client.GetRestaurantAsync(restaurantId, fields, accept);
            return _mapper.Map<RestaurantViewModel>(restaurant);
        }

        public async Task<RestaurantListViewModel> GetRestaurants(string? tag,string? searchQuery, int? pageSize, 
            int? pageNumber, string? orderBy, string? fields)
        {
            var restaurants = await _client.GetRestaurantsAsync(tag,searchQuery, pageNumber, pageSize, orderBy, fields);
            var pagedRestaurants = _mapper.Map<RestaurantListViewModel>(restaurants);
            return pagedRestaurants;

        }

        //public async Task<List<RestaurantListViewModel>> GetAllRestaurants()
        //{
        //    //_client.HttpClient.DefaultRequestHeaders.
        //    var allEvents = await _client.GetAllRestaurantsAsync();
        //    var mappedEvents = _mapper.Map<ICollection<RestaurantListViewModel>>(allEvents);
        //    return mappedEvents.ToList();
        //}

        //public async Task<RestaurantDetailViewModel> GetRestaurantById(Guid id)
        //{
        //    var selectedEvent = await _client.GetRestaurantAsync(id);
        //    var mappedEvent = _mapper.Map<RestaurantDetailViewModel>(selectedEvent);
        //    return mappedEvent;
        //}

        //public async Task<ApiResponse<Guid>> CreateRestaurant(RestaurantDetailViewModel eventDetailViewModel)
        //{
        //    try
        //    {
        //        CreateRestaurantCommand createEventCommand = _mapper.Map<CreateRestaurantCommand>(eventDetailViewModel);
        //        var newId = await _client.AddRestaurantAsync(createEventCommand);
        //        return new ApiResponse<Guid>() { Data = newId, Success = true };
        //    }
        //    catch (ApiException ex)
        //    {
        //        return ConvertApiExceptions<Guid>(ex);
        //    }
        //}

        //public async Task<ApiResponse<Guid>> UpdateRestaurant(RestaurantDetailViewModel eventDetailViewModel)
        //{
        //    try
        //    {
        //        UpdateRestaurantCommand updateEventCommand = _mapper.Map<UpdateRestaurantCommand>(eventDetailViewModel);
        //        await _client.UpdateRestaurantAsync(updateEventCommand);
        //        return new ApiResponse<Guid>() { Success = true };
        //    }
        //    catch (ApiException ex)
        //    {
        //        return ConvertApiExceptions<Guid>(ex);
        //    }
        //}

        //public async Task<ApiResponse<Guid>> DeleteRestaurant(Guid id)
        //{
        //    try
        //    {
        //        await _client.DeleteRestaurantAsync(id);
        //        return new ApiResponse<Guid>() { Success = true };
        //    }
        //    catch (ApiException ex)
        //    {
        //        return ConvertApiExceptions<Guid>(ex);
        //    }
        //}
    }
}

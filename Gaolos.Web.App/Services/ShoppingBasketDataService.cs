using AutoMapper;
using Blazored.LocalStorage;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account;
using Gaolos.Web.App.ViewModels.Basket;

namespace Gaolos.Web.App.Services
{
    public class ShoppingBasketDataService : BaseDataService, IShoppingBasketService
    {
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;
        public ShoppingBasketDataService(IClient client, ILocalStorageService localStorage, 
            IMapper mapper, ILoggedInUserService loggedInUserService)
            : base(client, localStorage)
        {
            _mapper = mapper;
            _loggedInUserService = loggedInUserService;
        }


        public async Task<ApiResponse<BasketLineViewModel>> AddItemToBasket(Guid basketId, MenuItemViewModel item, int quantity)
        {

            try
            {
                ApiResponse<BasketLineViewModel> response =  new ApiResponse<BasketLineViewModel>();
                BasketLineForCreationDto basketLine = new BasketLineForCreationDto
                {
                    Quantity = quantity,
                     MenuItemId = item.MenuItemId,
                     Price = item.Price
                };
                var createdLineResponse= await _client.AddBasketLineAsync(basketId, basketLine);
                if(createdLineResponse.Success)
                {
                    response.Data= _mapper.Map<BasketLineViewModel>(createdLineResponse.BasketLine);
                // response.Data = createdLineResponse.BasketLine;
                 response.Success = true;

                }else
                {
                    response.Data = null;
                    foreach (var error in createdLineResponse.ValidationErrors)
                    {
                        response.ValidationErrors+= error + Environment.NewLine;
                    }
                   // response.Success = false;

                }
                return response;
            }
            catch (ApiException<BasketLineViewModel> ex)
            { 
                return ConvertApiExceptions<BasketLineViewModel>(ex);
            }
        }

        public Task<ApiResponse> ApplyCouponToBasket(Guid basketId, Guid couponId)
        {
            throw new NotImplementedException();
        }

        public async Task ApplyCouponToBasket(Guid basketId, string couponCode)
        {
           await _client.ApplyCouponAsync(basketId, new CouponDto
           {
               Code = couponCode
           });
        }

        public async Task<ApiResponse<OrderViewModel>> Checkout(CheckoutViewModel checkout)
        {
            try
            {
                var user= await _loggedInUserService.GetUserDetails();

                if(user!=null)
                {
                    checkout.Email = user.Email;
                    checkout.Name = user.Name;
                    checkout.Phone = "012 345 6789";
                }

                ApiResponse<OrderViewModel> response = new ApiResponse<OrderViewModel>();
                CheckoutCommand checkoutCommand= _mapper.Map<CheckoutCommand>(checkout);
            
                if(user != null)
                {
                    checkoutCommand.UserId = user.UserId;
                }

                checkoutCommand.BasketId = await _localStorage.GetItemAsync<Guid>("basketId");
                var checkoutResponse =  await _client.CheckoutAsync(checkoutCommand);
               
                if(checkoutResponse.Success)
                {
                    response.Data = _mapper.Map<OrderViewModel>(checkoutResponse.Order);
                    response.Success = true;
                }else
                {
                    response.Data = null;
                    foreach (var error in checkoutResponse.ValidationErrors)
                    {
                        response.ValidationErrors+= error + Environment.NewLine;
                    }
                }
                return response;

            }catch(ApiException ex)
            {
                return ConvertApiExceptions<OrderViewModel>(ex);
            }

        }

        public async Task<ApiResponse<BasketViewModel>> CreateBasket()
        {
            try
            {
                var user= await _loggedInUserService.GetUserDetails();
                ApiResponse<BasketViewModel> response = new ApiResponse<BasketViewModel>();
                var userId= user != null ? user.UserId : Guid.NewGuid();
                var createBasketResponse = await _client.AddBasketAsync(new CreateBasketCommand { UserId= userId });
                if(createBasketResponse.Success)
                {
                    response.Data = _mapper.Map<BasketViewModel>( createBasketResponse.Basket);
                    response.Success = true;
                    await _localStorage.SetItemAsync("basketId", response.Data.BasketId);


                }
                else
                {
                    response.Data = null;
                    foreach (var error in createBasketResponse.ValidationErrors)
                    {
                        response.ValidationErrors+= error + Environment.NewLine;
                    }
                }
                return response;

            }catch(ApiException<BasketViewModel> ex)
            {
                return ConvertApiExceptions<BasketViewModel>(ex);
            }
        }

        public async Task<BasketViewModel> GetBasket(Guid basketId)
        {
            var basket = await _client.GetBasketAsync(basketId);

            return _mapper.Map<BasketViewModel>(basket);
        }

        public Task<BasketLineViewModel> GetBasketLine(Guid basketId, Guid basketLineId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BasketLineViewModel>> GetBasketLines(Guid basketId)
        {
            var basketLines = await _client.GetBasketLinesAsync(basketId);
            return _mapper.Map<IEnumerable<BasketLineViewModel>>(basketLines);
        }

        public async Task<int> GetItemCount(Guid basketId, Guid menuItemId)
        {
            var basketLines = await _client.GetBasketLinesAsync(basketId);
            var line =  basketLines.FirstOrDefault(x => x.MenuItemId == menuItemId);
            return line != null ? line.Quantity : 0;
        }

        public async Task RemoveItemFromBasket(Guid basketId, Guid basketLineId)
        {
            try
            {
                await _client.DeleteBasketlineAsync(basketId, basketLineId);
            }
            catch (ApiException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateBasketLine(Guid basketId, Guid basketLineId, int Quantity)
        {
            await _client.UpdateBasketlineAsync(basketId, basketLineId,
                new BasketLineForUpdateDto { Quantity = Quantity });
        }
    }
}

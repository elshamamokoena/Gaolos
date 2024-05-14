using AutoMapper;
using Blazored.LocalStorage;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;

namespace Gaolos.Web.App.Services
{
    public class AccountDataService : BaseDataService, IAccountDataService
    {
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;
        public AccountDataService(IClient client, 
            ILoggedInUserService loggedInUserService, IMapper mapper,
            ILocalStorageService localStorage) : base(client,localStorage
            )
        {
            _mapper = mapper;
            _loggedInUserService = loggedInUserService;
        }
        public async Task<ApiResponse<CreatedAddressVm>> AddDeliveryAddress(DeliveryAddressViewModel deliveryAddress)
        {
            var user = await _loggedInUserService.GetUserDetails();

            try { 
                ApiResponse<CreatedAddressVm> apiResponse = new ApiResponse<CreatedAddressVm>();
                AddressForCreationDto address = _mapper.Map<AddressForCreationDto>(deliveryAddress);

                var createAddressCommandResponse =
                await _client.CreateAddressAsync(user.UserId, address);

                if (createAddressCommandResponse.Success)
                {
                    apiResponse.Data = _mapper.Map<CreatedAddressVm>(createAddressCommandResponse.Address);
                    apiResponse.Success = true;
                }
                else
                {
                    apiResponse.Data = null;
                    foreach (var error in createAddressCommandResponse.ValidationErrors)
                    {
                        apiResponse.ValidationErrors+= error + Environment.NewLine;
                    }
                }
               return apiResponse;
            }
            catch (ApiException ex)
            { 
                return ConvertApiExceptions<CreatedAddressVm>(ex);
            }
        }

        public async Task<ApiResponse<CreatedPaymentMethodVm>> AddPaymentMethod(PaymentMethodViewModel paymentMethod)
        {
            var user = await _loggedInUserService.GetUserDetails();
            try
            {
               ApiResponse<CreatedPaymentMethodVm> apiResponse = new ApiResponse<CreatedPaymentMethodVm>();
                PaymentMethodForCreationDto paymentMethodForCreation = _mapper.Map<PaymentMethodForCreationDto>(paymentMethod);
                var createPaymentMethodCommandResponse = await _client.CreatePaymentMethodAsync(user.UserId, paymentMethodForCreation);
                if (createPaymentMethodCommandResponse.Success)
                {
                    apiResponse.Data = _mapper.Map<CreatedPaymentMethodVm>(createPaymentMethodCommandResponse.PaymentMethod);
                    apiResponse.Success = true;
                }
                else
                {
                    apiResponse.Data = null;
                    foreach (var error in createPaymentMethodCommandResponse.ValidationErrors)
                    {
                        apiResponse.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return apiResponse;

            }catch(ApiException ex)
            {
                return ConvertApiExceptions<CreatedPaymentMethodVm>(ex);
            }
        }

        public async Task DeleteDeliveryAddress(Guid addressId)
        {
            var user = await _loggedInUserService.GetUserDetails();
            await _client.DeleteAddressAsync(user.UserId,addressId);
        }

        public async Task DeletePaymentMethod(Guid creditcardId)
        {
            var user = await _loggedInUserService.GetUserDetails();
            await _client.DeletePaymentMethodAsync(user.UserId, creditcardId);
        }

        public async Task<IEnumerable<DeliveryAddressViewModel>> GetDeliveryAddresses()
        {
            var user = await _loggedInUserService.GetUserDetails();
            var addresses = await _client.GetUserAddressesAsync(user.UserId);
            return  _mapper.Map<IEnumerable<DeliveryAddressViewModel>>(addresses);
        }

        public async Task<OrderViewModel> GetOrder(Guid orderId)
        {
            var user = await _loggedInUserService.GetUserDetails();
            var order = await _client.GetOrderForUserAsync(user.UserId, orderId);
            return _mapper.Map<OrderViewModel>(order);
        }

        public async Task<PagedOrdersViewModel> GetOrders(string orderBy, OrderStatus ?orderStatus, string searchQuery,
            int pageNumber, int pageSize , string fields  )
        {
            var user = await _loggedInUserService.GetUserDetails();
            var orders = await _client.GetOrdersForUserAsync(user.UserId,
                orderBy,orderStatus, searchQuery, pageNumber, pageSize, fields );

            return _mapper.Map<PagedOrdersViewModel>(orders);



        }

        public async Task<IEnumerable<PaymentMethodViewModel>> GetPaymentMethods()
        {
            var user = await _loggedInUserService.GetUserDetails();
            var paymentMethods = await _client.GetPaymentMethodsAsync(user.UserId);
            return _mapper.Map<IEnumerable<PaymentMethodViewModel>>(paymentMethods);

        }

        public async Task<DeliveryAddressViewModel> GetPrimaryDeliveryAddress()
        {
           var user = await _loggedInUserService.GetUserDetails();
            var address = await _client.GetPrimaryAddressAsync(user.UserId);
            return _mapper.Map<DeliveryAddressViewModel>(address);
        }

        public async Task<PaymentMethodViewModel> GetPrimaryPaymentMethod()
        {
            var user = await _loggedInUserService.GetUserDetails();
            var paymentMethod = await _client.GetPrimaryPaymentMethodAsync(user.UserId);
            return _mapper.Map<PaymentMethodViewModel>(paymentMethod);
        }

        public async Task UpdateDeliveryAddress(DeliveryAddressViewModel deliveryAddress)
        {
            //try
            //{
                var user = await _loggedInUserService.GetUserDetails();

                AddressForUpdateDto addressForUpdate = _mapper.Map<AddressForUpdateDto>(deliveryAddress);

                await _client.UpdateAddressAsync(user.UserId, deliveryAddress.DeliveryAddressId, addressForUpdate);

                //var user = await _loggedInUserService.GetUserDetails();
                //ApiResponse<Guid> apiResponse = new ApiResponse<Guid>();
                //AddressForUpdateDto address = _mapper.Map<AddressForUpdateDto>(deliveryAddress);
                //var updateAddressCommandResponse = await _client.UpdateAddressAsync(user.UserId, );
                //if (updateAddressCommandResponse.)
                //{
                //    apiResponse.Data = updateAddressCommandResponse.AddressId;
                //    apiResponse.Success = true;
                //}
                //else
                //{
                //    apiResponse.Data = Guid.Empty;
                //    foreach (var error in updateAddressCommandResponse.ValidationErrors)
                //    {
                //        apiResponse.ValidationErrors += error + Environment.NewLine;
                //    }
                //}
                //return apiResponse;


            //}catch(ApiException ex)
            //{
            //    return ConvertApiExceptions<Guid>(ex);
            //}
        }

        public async Task UpdatePaymentMethod(PaymentMethodViewModel paymentMethod)
        {
            var user = await _loggedInUserService.GetUserDetails();
            PaymentMethodForUpdateDto paymentMethodForUpdate = _mapper.Map<PaymentMethodForUpdateDto>(paymentMethod);
            await _client.UpdatePaymentMethodAsync(user.UserId, paymentMethod.CreditCardId, paymentMethodForUpdate);
        }
    }
}

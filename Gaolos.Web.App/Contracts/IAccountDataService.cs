using Gaolos.Web.App.Services;
using Gaolos.Web.App.Services.Base;
using Gaolos.Web.App.ViewModels;
using Gaolos.Web.App.ViewModels.Account;
using Gaolos.Web.App.ViewModels.Account.DeliveryAddress;

namespace Gaolos.Web.App.Contracts
{
    public interface IAccountDataService
    {
        //Addresses
        Task<ApiResponse<CreatedAddressVm>> AddDeliveryAddress(DeliveryAddressViewModel deliveryAddress);
        Task<IEnumerable<DeliveryAddressViewModel>> GetDeliveryAddresses();
        Task<DeliveryAddressViewModel> GetPrimaryDeliveryAddress();

        Task UpdateDeliveryAddress(DeliveryAddressViewModel deliveryAddress);
        Task DeleteDeliveryAddress(Guid addressId);

        //Payment Methods
        Task<ApiResponse<CreatedPaymentMethodVm>> AddPaymentMethod(PaymentMethodViewModel paymentMethod);
        Task<IEnumerable<PaymentMethodViewModel>> GetPaymentMethods();
        Task<PaymentMethodViewModel> GetPrimaryPaymentMethod();
        Task UpdatePaymentMethod(PaymentMethodViewModel paymentMethod);
        Task DeletePaymentMethod(Guid creditcardId);

        //orders
        Task<PagedOrdersViewModel> GetOrders(string orderBy,OrderStatus ? orderStatus,
            bool? track, string searchQuery,
            int pageNumber, int pageSize, string fields);
        //Task<IEnumerable<OrderViewModel>> GetOrders();
        Task<OrderViewModel> GetOrder(Guid orderId);
    }
}

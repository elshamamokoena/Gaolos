using Gaolos.Application.Contracts.Persistence;
using Gaolos.Persistence.Repositories;
using Gaolos.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gaolos.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GaolosDbContext>(options =>
            {

                options.UseSqlServer(configuration.GetConnectionString("GaolosConnectionString"));
                options.EnableSensitiveDataLogging();
            }
            );

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IMenuItemsRepository, MenuItemsRepository>();
            services.AddScoped<IBasketLineRepository, BasketLineRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICreditCardRepository,CreditCardRepository>();
            services.AddTransient<IPropertyMappingService, PropertyMappingService>();
            return services;
        }
    }
}

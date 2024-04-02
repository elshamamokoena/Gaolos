using Gaolos.Application.Contracts.Services;
using Gaolos.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gaolos.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddTransient<IPropertyCheckerService, PropertyCheckerService>();

            return services;
        }
    }
}

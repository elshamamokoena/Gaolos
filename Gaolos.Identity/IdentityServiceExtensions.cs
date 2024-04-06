using Gaolos.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gaolos.Identity
{
    public static class IdentityServiceExtensions
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddIdentityCookies();

            services.AddAuthorizationBuilder();

            services.AddDbContext<GaolosIdentityDbContext>(options => 
                 options.UseSqlServer(configuration.GetConnectionString("GaolosIdentityConnectionString")));

            services.AddIdentityCore<ApplicationUser>()
                .AddEntityFrameworkStores<GaolosIdentityDbContext>()
                .AddApiEndpoints();
        }
    }
}

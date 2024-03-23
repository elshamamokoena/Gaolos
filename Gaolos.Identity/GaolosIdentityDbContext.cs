using Gaolos.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gaolos.Identity
{
    public class GaolosIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public GaolosIdentityDbContext()
        {

        }

        public GaolosIdentityDbContext(DbContextOptions<GaolosIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging();

    }
}

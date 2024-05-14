using Gaolos.Application.Contracts;
using Gaolos.Domain.Common;
using Gaolos.Domain.Entities.ShoppingCart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.DbContexts
{
    public class ShoppingBasketDbContext:DbContext
    {
        private readonly ILoggedInUserService? _loggedInUserService;


        public ShoppingBasketDbContext(DbContextOptions<ShoppingBasketDbContext> options)
            :base(options)
        {
        }
        public ShoppingBasketDbContext(ILoggedInUserService loggedInUserService, 
            DbContextOptions<ShoppingBasketDbContext> options):base(options) 
        {
            _loggedInUserService = loggedInUserService;
        }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;

                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
   
}

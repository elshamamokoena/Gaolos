using Gaolos.Application.Contracts;
using Gaolos.Domain.Common;
using Gaolos.Domain.Entities;
using Gaolos.Domain.Entities.UserAccount;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Persistence.DbContexts
{
    public class OrderDbContext:DbContext
    {
        private readonly ILoggedInUserService? _loggedInUserService;

        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            :base(options)
        {
        }

        public OrderDbContext(ILoggedInUserService loggedInUserService,
            DbContextOptions<OrderDbContext> options):base(options)
        {
            _loggedInUserService = loggedInUserService;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        //Delivery and Payments
        public DbSet<DeliveryAddress> Addresses { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

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

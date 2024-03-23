using Gaolos.Domain.Entities;
using Gaolos.Persistence;
using System;

namespace Gaolos.API.IntegrationTests.Base
{
    public class Utilities
    {
        public static void InitializeDbForTests(GaolosDbContext context)
        {
            var indianGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var italianGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            var mediterraneanGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
            var pizzaGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");

            context.Categories.Add(new Category
            {
                CategoryId = indianGuid,
                Name = "Indian cuis"
            });
            context.Categories.Add(new Category
            {
                CategoryId = italianGuid,
                Name = "Italian"
            });
            context.Categories.Add(new Category
            {
                CategoryId = mediterraneanGuid,
                Name = "Medi"
            });
            context.Categories.Add(new Category
            {
                CategoryId = pizzaGuid,
                Name = "pizza"
            });

            context.SaveChanges();
        }
    }
}

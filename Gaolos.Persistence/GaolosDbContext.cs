using Gaolos.Domain.Common;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Gaolos.Persistence
{
    public class GaolosDbContext : DbContext
    {
        public GaolosDbContext(DbContextOptions<GaolosDbContext> options)
           : base(options)
        {
        }

      //  public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

      //  public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GaolosDbContext).Assembly);

            //seed data, added through migrations
            var mediterraneanGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDA}");
            var pizzaGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B44E6A6}");
            var pastaGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
            var burgersGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var grillAndSteakGuid = Guid.Parse("{AE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var chickenGuid = Guid.Parse("{BE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var healthyGuid = Guid.Parse("{CE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var fishAndSeafoodGuid = Guid.Parse("{DE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var coffeeAndDessertsGuid = Guid.Parse("{EE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var asianGuid = Guid.Parse("{EE98F549-E790-5E9F-AA15-18C2292A2EE9}");
            var indianGuid = Guid.Parse("{EA98F549-E710-5E9F-AA15-18C2392A2EE9}");

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = mediterraneanGuid,
                Name = "Mediterranean",
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = asianGuid,
                Name = "Asian",
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = pizzaGuid,
                Name = "Pizza",
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

            });
     
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = pastaGuid,
                Name = "Pasta",
                ImageUrl = "img/food-delivery/category/02.jpg",
                SvgUrl = "img/food-delivery/icons/noodles.svg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = burgersGuid,
                Name = "Burgers",
                ImageUrl = "img/food-delivery/category/01.jpg",
                SvgUrl = "img/food-delivery/icons/burger.svg"


            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = grillAndSteakGuid,
                Name = "Grills & Steak",
                ImageUrl = "img/food-delivery/category/01.jpg",
                SvgUrl = "img/food-delivery/icons/steak.svg",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = chickenGuid,
                Name = "Chicken & Wings",
                SvgUrl = "img/food-delivery/icons/chicken.svg",
                ImageUrl= "img/food-delivery/category/01.jpg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = healthyGuid,
                Name = "Healthy",
                ImageUrl = "img/food-delivery/category/06.jpg",
                SvgUrl = "img/food-delivery/icons/healthy.svg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = fishAndSeafoodGuid,
                Name = "Fish & Seafood",
                ImageUrl = "img/food-delivery/category/03.jpg",
                SvgUrl = "img/food-delivery/icons/fish.svg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = coffeeAndDessertsGuid,
                Name ="Coffee & Desserts",
                ImageUrl = "img/food-delivery/category/05.jpg",
                SvgUrl = "img/food-delivery/icons/coffee.svg"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = indianGuid,
                Name = "Indian",
                ImageUrl = "img/food-delivery/category/05.jpg",
                SvgUrl = "img/food-delivery/icons/coffee.svg"
            });

            // seed restaurants
            var kfcGuid = Guid.Parse("{6313179F-7837-473A-A4D5-B5571B43E6A6}");
            var chickenlickenGuid = Guid.Parse("{6313179F-7837-473A-A4D5-C5571B43E6A6}");
            var nandosGuid = Guid.Parse("{6313179F-7837-473A-A4D5-D5571B43E6A6}");
            var romansGuid = Guid.Parse("{6313179F-7837-473A-A4D5-E5571B43E6A6}");
            var debonairsGuid = Guid.Parse("{6313179F-7837-473A-A4D5-F5571B43E6A6}");
            var mcdGuid = Guid.Parse("{6313179F-7837-473A-B4D5-A5571B43E6A6}");
            var steersGuid = Guid.Parse("{6313179F-7837-473A-C4D5-A5571B43E6A6}");
            var fishawaysGuid = Guid.Parse("{6313179F-7837-473A-D4D5-A5571B43E6A6}");
            var kungfuChickenGuid = Guid.Parse("{6313179F-7837-473A-E4D5-A5571B43E6A6}");
            var galitosGuid = Guid.Parse("{6313179F-7837-473A-F4D5-A5571B43E6A6}");
            var doppiozeroGuid = Guid.Parse("{1313179F-7837-473A-A4D5-A5571B43E6A6}");
            var mochachosGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A6}");

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = kfcGuid,
                Name = "KFC",
                CategoryId = chickenGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = chickenlickenGuid,
                Name = "Chicken Licken",
                CategoryId = chickenGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = nandosGuid,
                Name = "Nandos",
               CategoryId = chickenGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = romansGuid,
                Name = "Roman's Pizza",
                CategoryId = pizzaGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = debonairsGuid,
                Name = "Debonair's Pizza",
                CategoryId = pizzaGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mcdGuid,
                Name = "McDonald's",
                CategoryId = burgersGuid,

            });

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = steersGuid,
                Name = "Steers",
                CategoryId = burgersGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = fishawaysGuid,
                Name = "Fishaways",
                CategoryId = fishAndSeafoodGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = kungfuChickenGuid,
                Name = "Kung Fu Chicken",
                CategoryId = chickenGuid

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = galitosGuid,
                Name = "Galito's",
                CategoryId = chickenGuid,

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = doppiozeroGuid,
                Name = "Doppio Zero",
                CategoryId = mediterraneanGuid,


            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mochachosGuid,
                Name = "Mochachos",
                CategoryId = chickenGuid,

            });


            var simplyAsiaGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A6}");
            var andiccio24Guid = Guid.Parse("{2313179F-2837-473A-A4D5-A5571B43E6A6}");
            var pedrosGuid = Guid.Parse("{2313179F-3837-473A-A4D5-A5571B43E6A6}");
            var pizzaperfectGuid = Guid.Parse("{2313179F-4837-473A-A4D5-A5571B43E6A6}");
            var pronGuid = Guid.Parse("{2313179F-5837-473A-A4D5-A5571B43E6A6}");
            var theFussyVeganGuid= Guid.Parse("{2313179F-6837-473A-A4D5-A5571B43E6A6}");
            var pizzaBabyGuid = Guid.Parse("{2313179F-8837-473A-A4D5-A5571B43E6A6}");

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId= simplyAsiaGuid,
                Name = "Simply Asia",
                CategoryId= asianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = andiccio24Guid,
                Name = "Andiccio24",
                CategoryId= pizzaGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pedrosGuid,
                Name = "Pedro's Chicken",
                CategoryId= chickenGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaperfectGuid,
                Name = "Pizza Perfect",
                CategoryId= pizzaGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pronGuid,
                Name = "Pron",
                CategoryId= asianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = theFussyVeganGuid,
                Name = "The Fussy Vegan",
                CategoryId= healthyGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaBabyGuid,
                Name = "Pizza Baby",
                CategoryId= pizzaGuid,
            });

            var teiAvonGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A1}");
            var xoGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A2}");
            var haokelaiGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A3}");
            var momoBaohausGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A4}");
            var laPadrinoGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A5}");
            var asianTwistGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A7}");
            var thunderGunGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A8}");
            var chopStixGuid = Guid.Parse("{2313179F-1837-473A-A4D1-A5571B43E6A9}");

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = teiAvonGuid,
                Name = "Tei Avon",
                CategoryId= mediterraneanGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = xoGuid,
                Name = "X&O",
                CategoryId= coffeeAndDessertsGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = haokelaiGuid,
                Name = "Hao Ke Lai",
                CategoryId= asianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = momoBaohausGuid,
                Name = "Momo Baohaus",
                CategoryId= asianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = laPadrinoGuid,
                Name = "La Padrino",
                CategoryId= pizzaGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = asianTwistGuid,
                Name = "Asian Twist",
                CategoryId= asianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = thunderGunGuid,
                Name = "Thunder Gun",
                CategoryId= grillAndSteakGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = chopStixGuid,
                Name = "Chop Stix",
                CategoryId= asianGuid,
            });

            var mikesHeritageHouseGuid = Guid.Parse("{2313179F-1837-173A-A4D5-A5571B43E6A9}");
            var spiceBurgGreensideGuid = Guid.Parse("{2313179F-1837-273A-A4D5-A5571B43E6A9}");
            var miyakoSushiGuid = Guid.Parse("{2313179F-1837-373A-A4D5-A5571B43E6A9}");
            var curryUpGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A9}");
            var topoGigioGuid = Guid.Parse("{2313179F-1837-573A-A4D5-A5571B43E6A9}");
            var satoriGuid = Guid.Parse("{2313179F-1837-673A-A4D5-A5571B43E6A9}");
            var pizzaevinoGuid = Guid.Parse("{2313179F-1837-773A-A4D5-A5571B43E6A9}");
            var jimmysGuid = Guid.Parse("{2313179F-1837-873A-A4D5-A5571B43E6A9}");
            var pastaWorxGuid = Guid.Parse("{2313179F-1837-973A-A4D5-A5571B43E6A9}");

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mikesHeritageHouseGuid,
                Name = "Mike's Heritage House",
                CategoryId= grillAndSteakGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = spiceBurgGreensideGuid,
                Name = "Spiceburg Greenside",
                CategoryId= indianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = miyakoSushiGuid,
                Name = "Miyako Sushi",
                CategoryId = asianGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = curryUpGuid,
                Name = "Curry Up",
                CategoryId= indianGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = topoGigioGuid,
                Name = "Topo Gigio",
                CategoryId= pizzaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = satoriGuid,
                Name = "Satori",
                CategoryId= pizzaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaevinoGuid,
                Name = "Pizza e Vino",
                CategoryId= pizzaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = jimmysGuid,
                Name = "Jimmy's",
                CategoryId= fishAndSeafoodGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pastaWorxGuid,
                Name = "Pasta Worx",
                CategoryId = pastaGuid
            });




            //modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            //{
            //    EventId = Guid.Parse("{EE272F8B-6096-4CB6-8625-BB4BB2D89E8B}"),
            //    Name = "John Egbert Live",
            //    Price = 65,
            //    Artist = "John Egbert",
            //    Date = DateTime.Now.AddMonths(6),
            //    Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
            //    CategoryId = concertGuid
            //});

            //modelBuilder.Entity<Event>().HasData(new Event
            //{
            //    EventId = Guid.Parse("{3448D5A4-0F72-4DD7-BF15-C14A46B26C00}"),
            //    Name = "The State of Affairs: Michael Live!",
            //    Price = 85,
            //    Artist = "Michael Johnson",
            //    Date = DateTime.Now.AddMonths(9),
            //    Description = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/michael.jpg",
            //    CategoryId = concertGuid
            //});

            //modelBuilder.Entity<Event>().HasData(new Event
            //{
            //    EventId = Guid.Parse("{B419A7CA-3321-4F38-BE8E-4D7B6A529319}"),
            //    Name = "Clash of the DJs",
            //    Price = 85,
            //    Artist = "DJ 'The Mike'",
            //    Date = DateTime.Now.AddMonths(4),
            //    Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
            //    CategoryId = concertGuid
            //});

            //modelBuilder.Entity<Event>().HasData(new Event
            //{
            //    EventId = Guid.Parse("{62787623-4C52-43FE-B0C9-B7044FB5929B}"),
            //    Name = "Spanish guitar hits with Manuel",
            //    Price = 25,
            //    Artist = "Manuel Santinonisi",
            //    Date = DateTime.Now.AddMonths(4),
            //    Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/guitar.jpg",
            //    CategoryId = concertGuid
            //});

            //modelBuilder.Entity<Event>().HasData(new Event
            //{
            //    EventId = Guid.Parse("{1BABD057-E980-4CB3-9CD2-7FDD9E525668}"),
            //    Name = "Techorama Belgium",
            //    Price = 400,
            //    Artist = "Many",
            //    Date = DateTime.Now.AddMonths(10),
            //    Description = "The best tech conference in the world",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/conf.jpg",
            //    CategoryId = conferenceGuid
            //});

            //modelBuilder.Entity<Event>().HasData(new Event
            //{
            //    EventId = Guid.Parse("{ADC42C09-08C1-4D2C-9F96-2D15BB1AF299}"),
            //    Name = "To the Moon and Back",
            //    Price = 135,
            //    Artist = "Nick Sailor",
            //    Date = DateTime.Now.AddMonths(8),
            //    Description = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
            //    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/musical.jpg",
            //    CategoryId = musicalGuid
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{7E94BC5B-71A5-4C8C-BC3B-71BB7976237E}"),
            //    OrderTotal = 400,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{A441EB40-9636-4EE6-BE49-A66C5EC1330B}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{86D3A045-B42D-4854-8150-D6A374948B6E}"),
            //    OrderTotal = 135,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{AC3CFAF5-34FD-4E4D-BC04-AD1083DDC340}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{771CCA4B-066C-4AC7-B3DF-4D12837FE7E0}"),
            //    OrderTotal = 85,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{D97A15FC-0D32-41C6-9DDF-62F0735C4C1C}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{3DCB3EA0-80B1-4781-B5C0-4D85C41E55A6}"),
            //    OrderTotal = 245,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{4AD901BE-F447-46DD-BCF7-DBE401AFA203}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{E6A2679C-79A3-4EF1-A478-6F4C91B405B6}"),
            //    OrderTotal = 142,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{7AEB2C01-FE8E-4B84-A5BA-330BDF950F5C}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{F5A6A3A0-4227-4973-ABB5-A63FBE725923}"),
            //    OrderTotal = 40,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{F5A6A3A0-4227-4973-ABB5-A63FBE725923}")
            //});

            //modelBuilder.Entity<Order>().HasData(new Order
            //{
            //    Id = Guid.Parse("{BA0EB0EF-B69B-46FD-B8E2-41B4178AE7CB}"),
            //    OrderTotal = 116,
            //    OrderPaid = true,
            //    OrderPlaced = DateTime.Now,
            //    UserId = Guid.Parse("{7AEB2C01-FE8E-4B84-A5BA-330BDF950F5C}")
            //});
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

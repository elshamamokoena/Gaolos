using Gaolos.Application.Contracts;
using Gaolos.Domain.Common;
using Gaolos.Domain.Entities;
using Gaolos.Domain.Entities.Discount;
using Gaolos.Domain.Entities.ShoppingCart;
using Gaolos.Domain.Entities.UserAccount;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Gaolos.Persistence
{
    public class GaolosDbContext : DbContext
    {
        private readonly ILoggedInUserService? _loggedInUserService;

        public GaolosDbContext(DbContextOptions<GaolosDbContext> options)
           : base(options)
        {
        }

        public GaolosDbContext(DbContextOptions<GaolosDbContext> options,
            ILoggedInUserService loggedInUserService)
        : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }

        //catalogue
        public DbSet<Category> Categories { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }  
        public DbSet<Submenu> Submenus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        //shopping cart

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }

        //discount
        public DbSet<Coupon> Coupons { get; set; }

        //ordering
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        //Delivery and Payments
        public DbSet<DeliveryAddress> Addresses { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GaolosDbContext).Assembly);

            //seed data, added through migrations
            var hauteCuisine = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDA}");
            var pizzaAndPastaGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B44E6A6}");
            var noodlesGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
            var burgersAndFriesGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var grillAndSteakGuid = Guid.Parse("{AE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var chickenGuid = Guid.Parse("{BE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var healthyGuid = Guid.Parse("{CE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var fishAndSeafoodGuid = Guid.Parse("{DE98F549-E790-4E9F-AA16-18C2292A2EE9}");
            var coffeeAndDessertsGuid = Guid.Parse("{EE98F549-E790-4E9F-AA16-18C2292A2EE9}");
           // var asianGuid = Guid.Parse("{EE98F549-E790-5E9F-AA15-18C2292A2EE9}");
           // var indianGuid = Guid.Parse("{EA98F549-E710-5E9F-AA15-18C2392A2EE9}");

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = hauteCuisine,
                Name = "Haute Cuisine",
                ImageUrl = "img/food-delivery/category/10.jpg",
                SvgUrl = "img/food-delivery/icons/cuisine.svg",

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = noodlesGuid,
                Name = "Noodles",
                ImageUrl = "img/food-delivery/category/02.jpg",
                SvgUrl = "img/food-delivery/icons/noodles.svg",

            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = pizzaAndPastaGuid,
                Name = "Pizza & Pasta",
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

            });
     
        
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = burgersAndFriesGuid,
                Name = "Burgers & Fries",
                ImageUrl = "img/food-delivery/category/01.jpg",
                SvgUrl = "img/food-delivery/icons/burger.svg"


            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = grillAndSteakGuid,
                Name = "Grills & Steak",
                ImageUrl = "img/food-delivery/category/08.jpeg",
                SvgUrl = "img/food-delivery/icons/steak.svg",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = chickenGuid,
                Name = "Chicken & Wings",
                SvgUrl = "img/food-delivery/icons/chicken.svg",
                ImageUrl= "img/food-delivery/category/07.jpg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = healthyGuid,
                Name = "Healthy food",
                ImageUrl = "img/food-delivery/category/06.jpg",
                SvgUrl = "img/food-delivery/icons/healthy.svg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = fishAndSeafoodGuid,
                Name = "Fish & Seafood",
                ImageUrl = "img/food-delivery/category/09.jpg",
                SvgUrl = "img/food-delivery/icons/fish.svg"

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = coffeeAndDessertsGuid,
                Name ="Coffee & Desserts",
                ImageUrl = "img/food-delivery/category/05.jpg",
                SvgUrl = "img/food-delivery/icons/coffee.svg"
            });
       

            // seed restaurants
            var kfcGuid = Guid.Parse("{6313179F-7837-473A-A4D5-B5571B43E6A6}"); //pass
            var chickenlickenGuid = Guid.Parse("{6313179F-7837-473A-A4D5-C5571B43E6A6}"); //pass
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
                ImageUrl = "img/food-delivery/restaurants/02.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/04.png",
                Tags = "Chicken, Chicken Wings, Burgers, Wraps, Fast Food, Dessert, American, Spicy, Light Meals, Juice, Halaal, Breakfast,"
                
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = chickenlickenGuid,
                Name = "Chicken Licken",
                ImageUrl = "img/food-delivery/restaurants/10.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/14.png",
                Tags = "Chicken, Burgers, Chicken Wings, Spicy, Light Meals, Salad, Fast Food, Lunch, Dinner, Fries, Fried"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = nandosGuid,
                Name = "Nandos",
                ImageUrl = "img/food-delivery/restaurants/11.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/15.png",
                Tags= "Chicken, Burgers, Chicken Wings, Fast Food, Light Meals, Portuguese, Salad, Spicy, Dessert, South African, Dinner, Chips, Juice, Middle Eastern"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = romansGuid,
                Name = "Roman's Pizza",
                ImageUrl = "img/food-delivery/restaurants/12.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/16.png",
               Tags = "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, American, Dinner"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = debonairsGuid,
                Name = "Debonair's Pizza",
                ImageUrl = "img/food-delivery/restaurants/13.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/17.png",
                Tags = "Pizza, Fast Food, Italian, Chicken Wings, Dessert, Vegetarian, Halaal"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mcdGuid,
                Name = "McDonald's",
                ImageUrl = "img/food-delivery/restaurants/01.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/01.png",
                Tags = "Burgers, Fries, Fast Food, American, Breakfast, Dessert, Salad, Chicken, Juice, Halaal, Lunch, Dinner, Cafe, Coffee, Milkshake, Wraps"

            });

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = steersGuid,
                Name = "Steers",
                ImageUrl = "img/food-delivery/restaurants/14.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/18.png",
              Tags = "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = fishawaysGuid,
                Name = "Fishaways",
                ImageUrl = "img/food-delivery/restaurants/15.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/19.png",
           Tags = "Fish, Seafood, Fast Food, Halaal, Chips, Lunch, Dinner, Salad, Dessert, Juice, Healthy, Light Meals, Seafood, Grilled, Sushi, Mediterranean, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = kungfuChickenGuid,
                Name = "Kung Fu Chicken",
              ImageUrl = "img/food-delivery/restaurants/16.jpeg",
              LogoUrl = "img/food-delivery/restaurants/logos/20.png",
                 Tags = "Chicken, Fast Food, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = galitosGuid,
                Name = "Galito's",
                ImageUrl = "img/food-delivery/restaurants/17.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/21.png",
                Tags = "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = doppiozeroGuid,
                Name = "Doppio Zero",
                ImageUrl = "img/food-delivery/restaurants/18.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/22.png",
                Tags = "Italian, Vegan, Vegetarian, Pizza, Pasta, Burgers, Grill, Tapas, Woodfired, Healthy, Salad, Bakery, Breakfast, Calamari, Seafood, Chicken, Wraps, Poke, Mediterranean, Sandwiches, Dessert, Coffee, Health Drinks, Kids, Milkshake, Chips, Fruit, Haute"


            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mochachosGuid,
                Name = "Mochachos",
                ImageUrl = "img/food-delivery/restaurants/19.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/23.png",
               Tags = "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian, Grill, Lunch, Dinner, Mexican, Burrito, Prego, Halaal"

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
                ImageUrl = "img/food-delivery/restaurants/20.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/24.png",
                Tags = "Asian, Thai, Chinese, Japanese, Noodles, Sushi, Soup, Fried, Spicy, Healthy, Low Carb, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy, Traditional"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = andiccio24Guid,
                Name = "Andiccio24",
                ImageUrl = "img/food-delivery/restaurants/21.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/25.png",
                Tags = "Pizza, Pasta, Salad, Soup, Healthy, Smoothies, Dessert, Milkshake, Homemade, Oven Baked, Italian, Ice Cream, Contemporary, Wheat and Gluten free, Vegan, Mediterranean"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pedrosGuid,
                Name = "Pedro's Chicken",
                ImageUrl = "img/food-delivery/restaurants/22.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/26.png",
               Tags = "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaperfectGuid,
                Name = "Pizza Perfect",
                ImageUrl = "img/food-delivery/restaurants/23.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/27.png",
                Tags = "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, Light Meals, Dinner, Chicken Wings, Kids, Vegetarian"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pronGuid,
                Name = "Pron",
                ImageUrl = "img/food-delivery/restaurants/24.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/28.png",
                Tags= "Chinese, Asian, Fried, Healthy, Tapas, Noodles, Spicy"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = theFussyVeganGuid,
                Name = "The Fussy Vegan",
                ImageUrl = "img/food-delivery/restaurants/25.jpeg",
                LogoUrl = "img/food-delivery/restaurants/logos/29.png",
                Tags= "Breakfast, Burgers, Burrito, Dessert, Healthy, Sandwiches, Plant-Based, Health Drinks, Health, Vegan"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaBabyGuid,
                Name = "Pizza Baby",
                ImageUrl = "img/food-delivery/restaurants/26.jpg",
                LogoUrl = "img/food-delivery/restaurants/logos/30.png",
                Tags= "Pasta, Pizza, Salad, Italian, Fast Food, Dessert, Healthy, Chicken, Non-Alcoholic, Vegetarian"
            });

   //         var teiAvonGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A1}");
   //         var xoGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A2}");
   //         var haokelaiGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A3}");
   //         var momoBaohausGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A4}");
   //         var laPadrinoGuid = Guid.Parse("{2313179F-7837-473A-A4D5-A5571B43E6A5}");
   //         var asianTwistGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A7}");
   //         var thunderGunGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A8}");
   //         var chopStixGuid = Guid.Parse("{2313179F-1837-473A-A4D1-A5571B43E6A9}");

   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = teiAvonGuid,
   //             Name = "Tei Avon",
   //     //        CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = xoGuid,
   //             Name = "X&O",
   //        //     CategoryId= coffeeAndDessertsGuid,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = haokelaiGuid,
   //             Name = "Hao Ke Lai",
   //       //      CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = momoBaohausGuid,
   //             Name = "Momo Baohaus",
   //       //      CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = laPadrinoGuid,
   //             Name = "La Padrino",
   //     //        CategoryId= pizzaAndPastaGuid,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = asianTwistGuid,
   //             Name = "Asian Twist",
   // //            CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = thunderGunGuid,
   //             Name = "Thunder Gun",
   ////             CategoryId= grillAndSteakGuid,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = chopStixGuid,
   //             Name = "Chop Stix",
   ////             CategoryId= hauteCuisine,
   //         });

   //         var mikesHeritageHouseGuid = Guid.Parse("{2313179F-1837-173A-A4D5-A5571B43E6A9}");
   //         var spiceBurgGreensideGuid = Guid.Parse("{2313179F-1837-273A-A4D5-A5571B43E6A9}");
   //         var miyakoSushiGuid = Guid.Parse("{2313179F-1837-373A-A4D5-A5571B43E6A9}");
   //         var curryUpGuid = Guid.Parse("{2313179F-1837-473A-A4D5-A5571B43E6A9}");
   //         var topoGigioGuid = Guid.Parse("{2313179F-1837-573A-A4D5-A5571B43E6A9}");
   //         var satoriGuid = Guid.Parse("{2313179F-1837-673A-A4D5-A5571B43E6A9}");
   //         var pizzaevinoGuid = Guid.Parse("{2313179F-1837-773A-A4D5-A5571B43E6A9}");
   //         var jimmysGuid = Guid.Parse("{2313179F-1837-873A-A4D5-A5571B43E6A9}");
   //         var pastaWorxGuid = Guid.Parse("{2313179F-1837-973A-A4D5-A5571B43E6A9}");

   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = mikesHeritageHouseGuid,
   //             Name = "Mike's Heritage House",
   //   //          CategoryId= grillAndSteakGuid,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = spiceBurgGreensideGuid,
   //             Name = "Spiceburg Greenside",
   //     //        CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = miyakoSushiGuid,
   //             Name = "Miyako Sushi",
   //  //           CategoryId = hauteCuisine
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = curryUpGuid,
   //             Name = "Curry Up",
   //   //          CategoryId= hauteCuisine,
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = topoGigioGuid,
   //             Name = "Topo Gigio",
   //  //           CategoryId= pizzaAndPastaGuid
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = satoriGuid,
   //             Name = "Satori",
   //        //     CategoryId= pizzaAndPastaGuid
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = pizzaevinoGuid,
   //             Name = "Pizza e Vino",
   //        //     CategoryId= pizzaAndPastaGuid
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = jimmysGuid,
   //             Name = "Jimmy's",
   //       //      CategoryId= fishAndSeafoodGuid
   //         });
   //         modelBuilder.Entity<Restaurant>().HasData(new Restaurant
   //         {
   //             RestaurantId = pastaWorxGuid,
   //             Name = "Pasta Worx",
   //      //       CategoryId = pizzaAndPastaGuid
   //         });


            //seed menus for chicken licken

            //chicken licken menus and chicken licken menu items

            var chickenLickenMealGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A1}");
            var chickenLickenHotwingsGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A2}");
            var chickenLickenSouliciousGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A3}");
            var chickenLickenSoulSisterGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A4}");
            var chickenLickenJustGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A5}");
            var chickenLickenEasyBucksGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A6}");
            var chickenLickenBurgersGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A7}");
            var chickenLickenTopDeluxeGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A8}");
            var chickenLickenSoulBitesGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A9}");
            var chickenLickenOriginalSlydersGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6A0}");
            //var chickenLickenSuperSlidersGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B1}");
            //var chickenLickenExtraLickenGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B2}");
            //var chickenLickenChickyLickyGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B3}");
            //var chickenLickenSaladLickenGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B4}");
            //var chickenLickenLekkerGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B5}");
            //var chickenLickenCoolersGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B6}");
            //var chickenLickenSecretMenuGuid = Guid.Parse("{2014179F-1037-173A-A4D5-A6571B43E6B7}");

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenMealGuid,
                Name = "Meals",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you want more for everyone"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Lunch Meal",
                Price = 73.00M,
                MenuId = chickenLickenMealGuid,
                Description = "2 pieces + toast + 300ml Coke",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/63_lunch-meal.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Lunch Meal Max",
                Price = 76.00M,
                MenuId = chickenLickenMealGuid,
                Description = "2 pieces + toast + 440ml Coke",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/64_lunch-meal-max.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Meal",
                Price = 86.00M,
                MenuId = chickenLickenMealGuid,
                Description = "8 Hotwings + toast + 440ml Coke",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/65_hotwings-meal-circle8ce.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Meal Max",
                Price = 90.00M,
                MenuId = chickenLickenMealGuid,
                Description = "8 Hotwings + toast + 300ml Coke",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/66_hotwings-meal-max-circle8ce.png"
            });
       

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenHotwingsGuid,
                Name = " Just Hotwings",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When the craving's got you"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "6 Hotwings",
                Price = 42.00M,
                MenuId = chickenLickenHotwingsGuid,
                Description = "6 Hotwings",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/98_hotwings-circle6ce.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "12 Hotwings",
                Price = 84.00M,
                MenuId = chickenLickenHotwingsGuid,
                Description = "12 Hotwings",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/3_hotwings-circle12ce.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "24 Hotwings",
                Price = 168.00M,
                MenuId = chickenLickenHotwingsGuid,
                Description = "24 Hotwings",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/4_hotwings-circle24ce.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "36 Hotwings",
                Price = 231.00M,
                MenuId = chickenLickenHotwingsGuid,
                Description = "36 Hotwings",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/5_hotwings-circle36ce.png"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenSouliciousGuid,
                Name = "Soulicious",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you need some soul food"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Square Meal",
                Price = 50.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description = "1 Piece + 4 Hotwing®s + 1 Licken Loaf",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/128_soul-square-meal-.png"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Soul",
                Price = 50.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description = "6 Hotwings® + a portion of Soul Fries™",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/14_hotwings-soul-circle6ce.png"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Rock My Soul 3 Straight",
                Price = 57.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "3 pieces SoulFire® chicken + 1 sachet SoulFire® sauce",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/19_rock-my-soul-circle3cew-straight.png"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Rock My Soul 3 Combo",
                Price = 60.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description = "3 pieces SoulFire® chicken + a portion of Soul Fries™\r\n\r\n+ 1 sachet SoulFire® sauce ",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/20_rock-my-soul-circle3ce.png"

            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Deluxe",
                Price = 67.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "6 Hotwings® + a portion of Soul Fries™ + 300ml Coke",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/15_hotwings-circle6ce-deluxe.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Max",
                Price = 69.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "6 Hotwings® + a portion of Soul Fries™ + 440ml Coke",
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/16_hotwings-circle6ce-max.png"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Feed My Craving",
                Price = 79.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "10 Hotwings® + a portion of Soul Fries™",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/18_feed-my-craving-circle10ce.png"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soulman Load Up",
                Price = 80.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "Love Me Tender® Burger + a regular Soul Fries™\r\n\r\n+ 2 Hotwings® + 440ml Coke",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/22_soulman-load-up.png"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Rock My Soul",
                Price = 105.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "6 pieces SoulFire® chicken + 1 regular Soul Fries™\r\n\r\n+ 2 sachets SoulFire® sauce",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/21_rock-my-soul-circle6ce.png"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Party",
                Price = 132.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "16 Hotwings® + 2 regular Soul Fries™",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/17_hotwings-party-circle16ce.png"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Family Full House",
                Price = 143.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "6 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/24_family-full-house-circle6ce.png"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Mates Classic Party",
                Price = 145.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description= "12 Hotwings® + 4 Sliders®\r\n\r\n+ 2 regular Soul Fries™",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/23_soul-mates-classic-party.png"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Family Full House",
                Price = 173.00M,
                MenuId = chickenLickenSouliciousGuid,
                Description = "8 pieces + 2 regular Soul Fries™\r\n\r\n+ 2 regular Soulslaw® / Achaar / Tomato Salsa\r\n\r\n+ 2 Licken Loafs®",
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/25_family-full-house-circle8ce.png"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenSoulSisterGuid,
                Name = "Soul Sister Specials",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When a sister needs some soul"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister Vibe",
                Price = 40.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl= "https://chickenlicken.co.za/assets/uploads/products/menu/129_soulsister-2-vibe.png",
                Description = "2 pieces + a Licken Loaf"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister",
                Price = 43.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/49_soulsister-circle2ce.png",
                Description= "2 pieces + a portion of Soul Fries™"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister Deluxe",
                Price = 62.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/50_soulsister-circle2ce-deluxe.png",
                Description= "2 pieces + a portion of Soul Fries™ + 300ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister Max",
                Price = 65.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/51_soulsister-circle2ce-max.png",
                Description= "2 pieces + a portion of Soul Fries™ + 440ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister Party",
                Price = 84.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/52_soulsister-party-circle4ce.png",
                Description= "4 pieces + a portion of Soul Fries™ + 300ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Sister Party",
                Price = 112.00M,
                MenuId = chickenLickenSoulSisterGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/53_soulsister-party-circle5ce.png",
                Description= "5 pieces + a portion of Soul Fries™ + 440ml Coke"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenJustGuid,
                Name = "Just Chicken",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you just can't resist"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 1",
                Price = 20.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/54_just-circle1ce.png",
                Description = "1 piece"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 2",
                Price = 39.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/55_just-circle2ce.png",
                Description = "2 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 3",
                Price = 60.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/56_just-circle3ce.png",
                Description = "3 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 4",
                Price = 80.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/57_just-circle4ce.png",
                Description = "4 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 5",
                Price = 99.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/58_just-circle5ce.png",
                Description = "5 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Just 6",
                Price = 120.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/59_just-circle6ce.png",
                Description = "6 pieces"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Chicken Inn",
                Price = 150.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/60_chicken-inn-circle9ce.png",
                Description = "9 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Family Bucket",
                Price = 230.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/61_family-bucket-circle15ce.png",
                Description = "15 pieces"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Family Barrel",
                Price = 300.00M,
                MenuId = chickenLickenJustGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/62_family-barrel-circle21ce.png",
                Description = "21 pieces"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenEasyBucksGuid,
                Name = "Easy Bucks",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When it's almost mahala"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Slyder Snack",
                Price = 30.00M,
                MenuId = chickenLickenEasyBucksGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/44_slyder-snack-circle2ce.png",
                Description = "2 Original Slyders® + a portion of Soul Fries™"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Popcorn Chicken Shaker",
                Price = 30.00M,
                MenuId = chickenLickenEasyBucksGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/45_popcorn-chicken-shaker.png",
                Description= "Popcorn Chicken® in a shaker cup\r\n\r\n+ 2 sachets SoulFire® sauce or\r\n\r\n2 sachets of Uncle Jessup’s® Ketchup\r\n\r\nto shake up the taste!"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hotwings Snack",
                Price = 30.00M,
                MenuId = chickenLickenEasyBucksGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/46_hotwings-snack.png",
                Description= "4 Hotwings® + a portion of Soul Fries™"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Mix Snack",
                Price = 30.00M,
                MenuId = chickenLickenEasyBucksGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/47_soul-mix-snack.png",
                Description= "2 Hotwings® + a Slider®\r\n\r\n+ a portion of Soul Fries™"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Bites Snack",
                Price = 30.00M,
                MenuId = chickenLickenEasyBucksGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/125_soulbites-snack.png",
                Description= "4 SoulBites® + a portion of Soul Fries™ + a sachet of either \r\n\r\nUncle Jessups Ketchup®, SoulFire® sauce or Soulfirennaise™  sauce"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenBurgersGuid,
                Name = "Just Chick'n Burgers",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you're in the mood for a burger"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Tender",
                Price = 37.00M,
                MenuId = chickenLickenBurgersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/7_love-me-tender-burger.png",
                Description = "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce on a toasted sesame bun"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Hot",
                Price = 37.00M,
                MenuId = chickenLickenBurgersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/10_love-me-hot-burger.png",
                Description= "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce on a toasted sesame bun"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Tender Cheese Burger",
                Price = 40.00M,
                MenuId = chickenLickenBurgersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/9_love-me-tender-cheese-burger.png",
                Description= "Chicken fillet + lettuce + tomato\r\n\r\n+ Dreamy Creamy® sauce + a slice of cheese\r\n\r\non a toasted sesame bun"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Hot Cheese Burger",
                Price = 40.00M,
                MenuId = chickenLickenBurgersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/12_love-me-hot-cheese-burger.png",
                Description= "Chicken fillet + lettuce + tomato\r\n\r\n+ Soulfirenaise™ sauce + a slice of cheese\r\n\r\non a toasted sesame bun"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Big John",
                Price = 42.00M,
                MenuId = chickenLickenBurgersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/13_big-john-burger.png",
                Description= "2 Chicken Bresteaks® + lettuce + a slice of cheese\r\n\r\n+ 3 pickles + Dreamy Creamy® sauce\r\n\r\non a toasted sesame bun"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenTopDeluxeGuid,
                Name = "Top Deluxe",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you're hungry at heart"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Tender Top Deluxe",
                Price = 70.00M,
                MenuId = chickenLickenTopDeluxeGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/29_love-me-tender-top-deluxe.png",
                Description= "Includes a regular Soul Fries™ + 300ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Hot Top Deluxe",
                Price = 70.00M,
                MenuId = chickenLickenTopDeluxeGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/31_love-me-hot-top-deluxe.png",
                Description= "Includes a regular Soul Fries™ + 300ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Big John Top Deluxe",
                Price = 72.00M,
                MenuId = chickenLickenTopDeluxeGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/28_big-john-top-deluxe.png",
                Description= "Includes a regular Soul Fries™ + 300ml Coke"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Tender Cheese Top Deluxe",
                Price = 72.00M,
                MenuId = chickenLickenTopDeluxeGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/30_love-me-tender-cheese-top-deluxe.png",
                Description = "Includes a regular Soul Fries™ + 300ml Coke"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Love Me Hot Cheese Top Deluxe",
                Price = 72.00M,
                MenuId = chickenLickenTopDeluxeGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/32_love-me-hot-cheese-top-deluxe.png",
                Description= "Includes a regular Soul Fries™ + 300ml Coke"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenSoulBitesGuid,
                Name = "Soul Bites",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you need nuggets to feed your soul"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Bites",
                Price = 38.00M,
                MenuId = chickenLickenSoulBitesGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/123_soulbites-circle6ce.png",
                Description = "6 SoulBites®"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Soul Bites Max",
                Price = 45.00M,
                MenuId = chickenLickenSoulBitesGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/124_soulbites-circle9ce.png",
                Description = "9 SoulBites®"
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = chickenLickenOriginalSlydersGuid,
                Name = "Original Slyders",
                RestaurantId = chickenlickenGuid,
                CategoryId = chickenGuid,
                Description = "When you need a little snack"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "1 Slyder Original",
                Price = 14.00M,
                MenuId = chickenLickenOriginalSlydersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/33_1-slyder-original.png",
                Description = "Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "1 Slyder Chilli",
                Price = 14.00M,
                MenuId = chickenLickenOriginalSlydersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/39_1-slyder-chilli.png",
                Description= "Square chick’n burger on a toasted square bun with SOULFIRENAISE™ sauce and a pickle"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "1 Cheese Slyder",
                Price = 16.00M,
                MenuId = chickenLickenOriginalSlydersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/36_1-slyder-cheese.png",
                Description= "  Square chick’n burger on a toasted square bun with DREAMY CREAMY® sauce and a pickle and cheese"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "2 Original Slyders",
                Price = 27.00M,
                MenuId = chickenLickenOriginalSlydersGuid,
                ImageUrl = "https://chickenlicken.co.za/assets/uploads/products/menu/34_2-slyders-original.png",
                Description= "2 Square chick’n burgers on toasted square buns with DREAMY CREAMY® sauce and a pickle"
            });

            //seed menus for Nandos

            //nandos menus and nandos menu items
            var nandosPlattersGuid = Guid.Parse("{2013179F-1117-173A-A4D5-A6571B43E6A1}");
            var nandosNandinosGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A2}");
            var nandosBurgersGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A3}");
            var nandosPitasGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A4}");
            var nandosWrapsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A5}");
            var nandosSaladsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A6}");
            var nandosDessertsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A7}");
            var nandosDrinksGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A8}");
            var nandosBowlsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A9}");
            var nandosFullChickenGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A0}");
            var nandosHalfChickenGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6B1}");
            var nandosQuarterChickenGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6B2}");

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = nandosPlattersGuid,
                Name = "Platters",
                RestaurantId = nandosGuid,
                CategoryId = chickenGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Cabo Sosatie Snack Platter",
                Description = "A generous sharing platter of 4 succulent Flame-grilled Shisanyama Chicken Sosaties and 20 Winglets, served with 2 portions of our Sharing Wedges, 2 Garlic Rolls and our special PERinase dip.",
                Price = 349.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl= "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/3d93a55d-440a-407c-8b7b-97cc1e6c510a"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Big on veg platter",
                Description = "Half Platter",
                Price = 640.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl = "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/f93c9cbe-5f94-4bb4-a937-811c28bd88df"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Hands-on delicious platter",
                Description = "3 Pulled Chicken Wraps (cut into 6), 3 Chicken Wraps (cut into 6), 2 Sharing Wedges, 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.",
                Price = 640.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl = "https://imagesrv.nandos.co.za/179x212//MW_IMAGES/ccc05d6a-734b-4fec-bbc7-50a7da7ad2da"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "More to share platter",
                Description = "One and a 1/2 full chickens ( cut into 12), 2 Flame-grilled Mielies cut into 3 (6 portions), 4 Kids Burgers, 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.",
                Price = 640.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl = "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/5182f543-741a-4317-a731-e8098a228c37"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Peri-er Platter",
                Description = "Two full chickens (cut into 16), 16 Winglets, 2 Flame-grilled Mielies cut into 3 (6 portions), 2 Sharing Wedges. Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.",
                Price = 640.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl = "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/fa60cb07-3c21-4718-8f02-cb91fd83319b"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem()
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Veggie veggie nice platter",
                Description = "2 Veg Burgers, 2 Halloumi & Roast Veg Wraps, 2 Halloumi & Roast Veg Pitas, 2 Sharing Wedges, 4 Flame-grilled Mielies cut into 3 (12 portions). Includes 1 PERinaise dip and 1 Creamy dip. All platters serve 6-8 people.",
                Price = 640.00M,
                MenuId = nandosPlattersGuid,
                ImageUrl = "https://imagesrv.nandos.co.za/179x215//MW_IMAGES/3b7bc5aa-eb6c-4f3b-a289-ae9669f410dd"
            });






            //seed menus for kfc

            //kfc menus and kfc menu items
            var kfcBucketsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A1}");
            var kfcBoxMealsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A2}");
            var kfcStreetwiseGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A3}");
            var kfcDrinksAndTreatsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A4}");
            var kfcSharingGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A5}");
            var kfcWingsAndSnacksGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A6}");
            var kfcBurgersAndWrapsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A7}");
            var kfcAddOnsGuid = Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A8}");

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcBucketsGuid,
                Name= "Buckets",
                RestaurantId= kfcGuid,
                CategoryId= chickenGuid
            });


            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId =  Guid.Parse("{2013179F-1037-173A-A4D5-A6571B43E6A9}"),
                Name = "21 Piece Bucket",
                Description = "21 Pieces of juicy chicken seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.",
                Price = 365.90M,
                MenuId = kfcBucketsGuid,
                ImageUrl = "https://images.ctfassets.net/0p42pznmbeec/6eaDUybzXwyTZS51VNINU3/ed40587af0f56e4f8b753f4352a02f09/66752_-_E-Commerce_21_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill"
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "15 Piece Bucket",
                Description = "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.",
                Price = 279.90M,
                MenuId = kfcBucketsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/WKTb7n2vvpdYR1v8mvXX0/4d01e6a6cf892c116f2e82bdd4b64b6a/66752_-_E-Commerce_15_pc_Bucket_1200x900.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "9 Piece Bucket",
                Description = "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.",
                Price = 182.90M,
                MenuId = kfcBucketsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2ZE6o3XzzI7YzGsVVT4ubY/e95c55d0c1b050b91a2b070a5ad1b32e/9_piece_bucket.jpg?h=600&w=800&fm=webp&fit=fill"
            });


            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcBoxMealsGuid,
                Name = "Box Meals",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Fully Loaded Box Meal",
                Description = "The new Burger standard…Boxed! The new Colonel burger, 1 piece of original recipe chicken, regular mash & gravy, chips & a buddy no sugar drink.",
                Price = 115.90M,
                MenuId = kfcBoxMealsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/31yPC9ryh5KT1pOdwEOOzG/d1e2df6fc99eaf513f84b63f7d475f58/65129_kfc_-_FLBM_cheese_buddy_1200x900.jpg?h=600&w=800&fm=webp&fit=fill"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Zinger Fully Loaded Buddy Box Meal",
                Description = "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.",
                Price = 115.90M,
                MenuId = kfcBoxMealsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/3spYrESfEqEyv4TaIwhQnZ/e315445416a59f4ba60acf90090482dd/62279_WickedZinger_SF_-_1200x900.png?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Nugget Box Buddy Meal",
                Description = "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink",
                Price = 79.90M,
                MenuId = kfcBoxMealsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/1L5C3sZ1MmaHtuQLewHqYa/5e4ecba1d83ade38d554eba1a7431551/ABC2120-nugget_box_buddy_1.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "All Star Box Meal Buddy",
                Description = "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink",
                Price = 94.90M,
                MenuId = kfcBoxMealsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2tpR61h0KxupmA8U024fwu/55f538f6ae4384b9bbdf598435d6ea53/ABC1696-all_star_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Wrapsta Box Meal",
                Description = "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink",
                Price = 84.90M,
                MenuId = kfcBoxMealsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2snvT5LNlzizE6TGQ9KN4F/3f5c8ebf26502ad1bdf5a1cc456ccfc0/ABC1723-wrapsta_box_buddy.jpg?h=600&w=800&fm=webp&fit=fill"

            });









            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcStreetwiseGuid,
                Name = "Streetwise",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "SW Bozza Streetwise 1 Buddy",
                Description = "Get yourself a Streetwise 1, with a Buddy no sugar free drink",
                Price = 52.90M,
                MenuId = kfcStreetwiseGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "SW Bozza Crunch Burger Box Buddy",
                Description = "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink",
                Price = 71.90M,
                MenuId = kfcStreetwiseGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/3QpxFh5qLJj5GT8dEMW3iZ/3acbea341f4c8d3162163373ff8ed48f/COM2029-streetwise_bucket_for_1.jpg?h=600&w=800&fm=webp&fit=fill"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "SW Bozza Streetwise 5 Buddy",
                Description = "Get yourself a Streetwise 5, with 2 Buddy No Sugar",
                Price = 143.90M,
                MenuId = kfcStreetwiseGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2uwM3hjbse4hzaZv6d5peO/576343077547dc714bf02883a79589f6/ICM1009-streetwise_5_chips.jpg?h=600&w=800&fm=webp&fit=fill"
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Five",
                Description = "5 Pieces of Original Recipe chicken cooked to golden perfection and a large portion of chips or coleslaw.",
                Price = 121.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Three with Chips",
                Description = "3 Pieces of original recipe chicken, a portion of small chips.",
                Price = 72.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Three with Pap",
                Description = "3 Pieces of Original Recipe Chicken with a portion of pap and gravy",
                Price = 72.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Two with Chips",
                Description = "2 Pieces of Original Recipe Chicken and Small Chips or Coleslaw.",
                Price = 49.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Bucket For One",
                Description = "Enjoy a piece of original recipe chicken, 2 zinger wings and a small scrumptious chips.",
                Price = 46.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Streetwise Two with Pap",
                Description = "2 Pieces of original recipe chicken cooked to golden perfection and a regular portion of pap & small gravy.",
                Price = 49.90M,
                MenuId = kfcStreetwiseGuid
            });







            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcDrinksAndTreatsGuid,
                Name = "Drnks & Treats",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Cappy Juice 1.5 Litre",
                Description = "",
                Price = 44.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Oreo Krusher",
                Description = "An icy sippable treat with Oreo bitz, and creamy soft-serve.",
                Price = 42.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Verry Berry Krusher",
                Description = "An icy sippable treat with Berry bitz, and creamy soft-serve.",
                Price = 42.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Strawberry Milkshake",
                Description = "Milk shake milk shake shake shake",
                Price = 31.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Chocolate Milkshake",
                Description = "Chocolate Milkshake",
                Price = 31.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Coke 1.5 Litre Bottle",
                Description = "Coke 1.5 Litre Bottle",
                Price = 32.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Coke No Sugar 1.5 Litre",
                Description = "Coke No Sugar 1.5 Litre",
                Price = 29.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Coke No Sugar Buddy 440ml",
                Description = "Coke No Sugar Buddy 440ml",
                Price = 22.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Coca-Cola Sugar Buddy 440ml",
                Description = "Coca-Cola Sugar Buddy 440ml",
                Price = 24.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Fanta Sugar Buddy 440ml",
                Description = "Fanta Sugar Buddy 440ml",
                Price = 24.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Sprite Sugar Buddy 440ml",
                Description = "Sprite Sugar Buddy 440ml",
                Price = 24.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Bonaqua Still Spring Water 500ml",
                Description = "Bonaqua Still Spring Water 500ml",
                Price = 19.90M,
                MenuId = kfcDrinksAndTreatsGuid

            });









            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcSharingGuid,
                Name = "Sharing Meals",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "10 Piece Family Treat",
                Description = "10pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips",
                Price = 316.90M,
                MenuId = kfcSharingGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "8 Piece Family Treat",
                Description = "8pc Chicken, 2 snack burgers, 4 Zinger Wings, 2 Reg Coleslaw, 2 Reg chips",
                Price = 274.90M,
                MenuId = kfcSharingGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "24 Zinger Wings Bucket",
                Description = "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.",
                Price = 194.90M,
                MenuId = kfcSharingGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "All In One Feast",
                Description = "Enjoy 6 pieces of delicious original recipe chicken, 1 large chips, 1 regular coleslaw plus 2 regular mash and gravies.",
                Price = 194.90M,
                MenuId = kfcSharingGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "2 Can Dine Buddy",
                Description = "Enjoy 4 pieces of original recipe chicken, 2 small chips, 1 small pops & 2 buddy no sugar drinks.",
                Price = 164.90M,
                MenuId = kfcSharingGuid

            });











            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcWingsAndSnacksGuid,
                Name = "Wings & Snacks",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Jalapeno Loaded Fries",
                Description = "Enjoy KFC`s new Jalapeno loaded fries with brand new Hot * spicy sauce",
                Price = 32.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "24 Zinger Wings Bucket",
                Description = "24 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.",
                Price = 194.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "10 Dunked Wings",
                Description = "10 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.",
                Price = 104.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "10 Hot Zinger Wings",
                Description = "10 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.",
                Price = 89.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Large Pops",
                Description = "Bite-sized pieces of chicken, tender on the inside and crunchy on the outside.",
                Price = 54.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Sprinkle Pops",
                Description = "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside. Served with a generous sprinkle of fruit chutney flavour.",
                Price = 54.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "4 Dunked Wings",
                Description = "4 KFC famous Zinger Wings dunked in a delicious honey, ginger and soy sauce.",
                Price = 54.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "4 Zinger Wings",
                Description = "4 Succulent winglets breaded in our hot Zinger breading to give you the delicious hot flavour you love, cooked to crispy-brown perfection.",
                Price = 48.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "9Pc Nuggets",
                Description = "9 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.",
                Price = 42.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Dunked Pops",
                Description = "Bite-sized pieces of chicken dunked in KFC’s famous honey, ginger and soy sauce!",
                Price = 36.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "6Pc Nuggets",
                Description = "6 pieces of crispy, delicious golden brown Nuggets, paired with 1 delicious Colonel dipping sauce.",
                Price = 36.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Small Pops",
                Description = "Bite-sized pieces of chicken that are tender on the inside and crunchy on the outside.",
                Price = 29.90M,
                MenuId = kfcWingsAndSnacksGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Snack Burger",
                Description = "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.",
                Price = 29.90M,
                MenuId = kfcWingsAndSnacksGuid

            });






            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcBurgersAndWrapsGuid,
                Name = "Burgers & Wraps",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "New Colonel Burger",
                Description = "Try the new standard! The New Colonel burger, Our trademark real chicken fillet; A fresh Brioche bun, Creamy Colonel sauce and cheese on a fresh bed of lettuce & succulent tomatoes",
                Price = 60.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "New Zinger Burger",
                Description = "Try the new standard! The New Crispy Zinger burger, Our trademark real chicken fillet; A fresh Brioche bun, New Hot & Spicy sauce and cheese on a fresh bed of lettuce & succulent tomatoes",
                Price = 60.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "New Double Crunch Burger",
                Description = "The new standard in burgers! 2 Spicy, crunchy mini fillets with 2 cheese slices, lettuce & tomato covered in tangy dressing on a burger bun",
                Price = 68.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Zinger Boxmaster",
                Description = "A warm tortilla wrapped around a delicious fillet zinger recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.",
                Price = 76.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Colonel Boxmaster",
                Description = "A warm tortilla wrapped around a delicious fillet original recipe - a slice of cheese, hash brown, crisp lettuce, fresh tomato and a dash of Colonel dressing.",
                Price = 76.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Classic Twister",
                Description = "A warm tortilla wrapped around 2 deliciously crispy chicken strips, shredded crisp lettuce, sliced tomato and a dash of Colonel dressing.",
                Price = 66.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Sweet Chilli Twister",
                Description = "A warm tortilla wrapped around 2 deliciously crispy new and improved chicken strips, shredded crisp lettuce, sliced tomato, topped with Colonel dressing and sweet chilli sauce.",
                Price = 66.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Wrapsta",
                Description = "The game changer is here, and with a delicious spicy crunch fillet, tomato, lettuce and cheese with tangy dressing all wrapped up in a mini tortilla and grilled to perfection, meal time will never be the same again.",
                Price = 42.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Crunch Burger",
                Description = "A spicy, crunchy mini fillet with a slice of cheese and lettuce, covered in tangy dressing on a snack bun.",
                Price = 36.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Snack Burger",
                Description = "A delicious chicken patty served with shredded lettuce & Colonel dressing on a snack bun.",
                Price = 29.90M,
                MenuId = kfcBurgersAndWrapsGuid

            });





            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = kfcAddOnsGuid,
                Name = "Add-Ons",
                RestaurantId = kfcGuid,
                CategoryId = chickenGuid
            });



            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Sauce - Hot & Spicy",
                Description = "Extra Hot & Spicy Zinger sauce on the side",
                Price = 0,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/bEZLbUGmprwC7wW3i0GsS/73b63ef3ac73d2e805688b74cdbc31c0/Hot_n_Spicy_sauce_-_1200x900.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Large Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 0,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/5Zt1jvrey6zim41HKaarJr/6c4e0a08f94a83f04ad98dc130ce67e1/CHI1002-lrg_chips.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 26.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/23emjPvgiS9FE3xT6UiBa/9a5d9ceffa02d18a26679472e7f62cfc/CHI1001-reg_chips.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "1 Piece Chicken",
                Description = "1 Piece Chicken",
                Price = 26.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2XhP71I12p5tncjyX1P81w/d94f9543674f4728165031f42dcb2653/ALA1001-1pc_cob.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Large Mash & Gravy",
                Description = "A portion of creamy mash and our delicious gravy.",
                Price = 27.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Coleslaw",
                Description = "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing",
                Price = 24.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/1LvCxHqjAFXs2XFgAbQpnG/44719dee762ff4f7106e33d8c4f300f9/ABC2225-reg_coleslaw.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Mash & Gravy",
                Description = "A portion of creamy mash and our delicious gravy.",
                Price = 19.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/16hT15F1AVhciJyE32xbGE/f83f8d8d906a2593420739e995086bc4/MAG1003-reg_mash___gravy.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Small Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 16.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/4J7RauzcyD6KkQu9Qhpp28/da6827d46db9161d26ae26c874be5123/ABC1247-sml_chips.jpg?h=600&w=800&fm=webp&fit=fill"

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Mini Loaf",
                Description = "Oven baked, fresh mini loaf",
                Price = 14.90M,
                MenuId = kfcAddOnsGuid,
                ImageUrl= "https://images.ctfassets.net/0p42pznmbeec/2X0ukPSNX6j4kHDE2o2mGa/e910e8f156eb5ca37642fb19944603a0/MIS1001-1_mini_loaf.jpg?h=600&w=800&fm=webp&fit=fill"

            });


            //Coupons
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = Guid.NewGuid(),
                Code = "BeNice",
                Discount = 10,
                AlreadyUsed = false
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = Guid.NewGuid(),
                Code = "Awesome",
                Discount = 20,
                AlreadyUsed = false
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = Guid.NewGuid(),
                Code = "AlmostFree",
                Discount = 50,
                AlreadyUsed = false
            });
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

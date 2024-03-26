using Gaolos.Application.Contracts;
using Gaolos.Domain.Common;
using Gaolos.Domain.Entities;
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

        public GaolosDbContext(DbContextOptions<GaolosDbContext> options, ILoggedInUserService loggedInUserService)
        : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }  
        public DbSet<Submenu> Submenus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }


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
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = noodlesGuid,
                Name = "Noodles",
                ImageUrl = "img/food-delivery/category/04.jpg",
                SvgUrl = "img/food-delivery/icons/pizza.svg",

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
                Name = "Healthy food",
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
                //  CategoryId = chickenGuid,
                Tags = "Chicken, Chicken Wings, Burgers, Wraps, Fast Food, Dessert, American, Spicy, Light Meals, Juice, Halaal, Breakfast,"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = chickenlickenGuid,
                Name = "Chicken Licken",
                Tags= "Chicken, Burgers, Chicken Wings, Spicy, Light Meals, Salad, Fast Food, Lunch, Dinner, Fries, Fried"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = nandosGuid,
                Name = "Nandos",
           //    CategoryId = chickenGuid,
                Tags= "Chicken, Burgers, Chicken Wings, Fast Food, Light Meals, Portuguese, Salad, Spicy, Dessert, South African, Dinner, Chips, Juice, Middle Eastern"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = romansGuid,
                Name = "Roman's Pizza",
            //    CategoryId = pizzaAndPastaGuid,
               Tags = "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, American, Dinner"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = debonairsGuid,
                Name = "Debonair's Pizza",
             //   CategoryId = pizzaAndPastaGuid,
               Tags = "Pizza, Fast Food, Italian, Chicken Wings, Dessert, Vegetarian, Halaal"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mcdGuid,
                Name = "McDonald's",
              //  CategoryId = burgersAndFriesGuid,
                Tags = "Burgers, Fries, Fast Food, American, Breakfast, Dessert, Salad, Chicken, Juice, Halaal, Lunch, Dinner, Cafe, Coffee, Milkshake, Wraps"

            });

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = steersGuid,
                Name = "Steers",
            //    CategoryId = burgersAndFriesGuid,
              Tags = "Burgers, Fries, Salad, Dessert, Chicken, Milkshake, Ribs, Ice Cream, Fast Food, Kids, Healthy, Chips, Vegetarian"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = fishawaysGuid,
                Name = "Fishaways",
           //     CategoryId = fishAndSeafoodGuid,
           Tags = "Fish, Seafood, Fast Food, Halaal, Chips, Lunch, Dinner, Salad, Dessert, Juice, Healthy, Light Meals, Seafood, Grilled, Sushi, Mediterranean, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = kungfuChickenGuid,
                Name = "Kung Fu Chicken",
           //     CategoryId = chickenGuid
                 Tags = "Chicken, Fast Food, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = galitosGuid,
                Name = "Galito's",
          //      CategoryId = chickenGuid,
                Tags = "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = doppiozeroGuid,
                Name = "Doppio Zero",
            //    CategoryId = hauteCuisine,
                Tags = "Italian, Vegan, Vegetarian, Pizza, Pasta, Burgers, Grill, Tapas, Woodfired, Healthy, Salad, Bakery, Breakfast, Calamari, Seafood, Chicken, Wraps, Poke, Mediterranean, Sandwiches, Dessert, Coffee, Health Drinks, Kids, Milkshake, Chips, Fruit"


            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = mochachosGuid,
                Name = "Mochachos",
          //      CategoryId = chickenGuid,
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
           //     CategoryId= hauteCuisine,
                Tags = "Asian, Thai, Chinese, Japanese, Noodles, Sushi, Soup, Fried, Spicy, Healthy, Low Carb, Light Meals, Salad, Lunch, Dinner, Juice, Chinese, Asian, Sushi, Soup, Fried, Japanese, Noodles, Spicy, Traditional"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = andiccio24Guid,
                Name = "Andiccio24",
            //    CategoryId= pizzaAndPastaGuid,
                Tags = "Pizza, Pasta, Salad, Soup, Healthy, Smoothies, Dessert, Milkshake, Homemade, Oven Baked, Italian, Ice Cream, Contemporary, Wheat and Gluten free, Vegan, Mediterranean"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pedrosGuid,
                Name = "Pedro's Chicken",
           //     CategoryId= chickenGuid,
               Tags = "Chicken, Spicy, Light Meals, Salad, Lunch, Dinner, Juice, Portuguese, African, Spicy, Halaal, Middle Eastern, Mediterranean, Healthy, Low Carb"

            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaperfectGuid,
                Name = "Pizza Perfect",
          //      CategoryId= pizzaAndPastaGuid,
            Tags = "Pizza, Pasta, Salad, Dessert, Lunch, Fast Food, Spicy, Mediterranean, Light Meals, Dinner, Chicken Wings, Kids, Vegetarian"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pronGuid,
                Name = "Pron",
           //     CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = theFussyVeganGuid,
                Name = "The Fussy Vegan",
          //      CategoryId= healthyGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaBabyGuid,
                Name = "Pizza Baby",
           //     CategoryId= pizzaAndPastaGuid,
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
        //        CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = xoGuid,
                Name = "X&O",
           //     CategoryId= coffeeAndDessertsGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = haokelaiGuid,
                Name = "Hao Ke Lai",
          //      CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = momoBaohausGuid,
                Name = "Momo Baohaus",
          //      CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = laPadrinoGuid,
                Name = "La Padrino",
        //        CategoryId= pizzaAndPastaGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = asianTwistGuid,
                Name = "Asian Twist",
    //            CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = thunderGunGuid,
                Name = "Thunder Gun",
   //             CategoryId= grillAndSteakGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = chopStixGuid,
                Name = "Chop Stix",
   //             CategoryId= hauteCuisine,
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
      //          CategoryId= grillAndSteakGuid,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = spiceBurgGreensideGuid,
                Name = "Spiceburg Greenside",
        //        CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = miyakoSushiGuid,
                Name = "Miyako Sushi",
     //           CategoryId = hauteCuisine
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = curryUpGuid,
                Name = "Curry Up",
      //          CategoryId= hauteCuisine,
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = topoGigioGuid,
                Name = "Topo Gigio",
     //           CategoryId= pizzaAndPastaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = satoriGuid,
                Name = "Satori",
           //     CategoryId= pizzaAndPastaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pizzaevinoGuid,
                Name = "Pizza e Vino",
           //     CategoryId= pizzaAndPastaGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = jimmysGuid,
                Name = "Jimmy's",
          //      CategoryId= fishAndSeafoodGuid
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = pastaWorxGuid,
                Name = "Pasta Worx",
         //       CategoryId = pizzaAndPastaGuid
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
                MenuId = kfcBucketsGuid
            });

            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "15 Piece Bucket",
                Description = "15 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs & spices.",
                Price = 279.90M,
                MenuId = kfcBucketsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "9 Piece Bucket",
                Description = "9 Pieces of juicy Original Recipe chicken, seasoned with the 11 secret herbs and spices of Original Recipe® chicken, marinated and cooked to perfection.",
                Price = 182.90M,
                MenuId = kfcBucketsGuid
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
                MenuId = kfcBoxMealsGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Zinger Fully Loaded Buddy Box Meal",
                Description = "The new Burger standard…Boxed! The Crispy Zinger burger, 1 piece of original recipe chicken, regular mash & gravy, chips & Buddy no sugar.",
                Price = 115.90M,
                MenuId = kfcBoxMealsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Nugget Box Buddy Meal",
                Description = "4 Nuggets, 1 Crunch Burger, 1 Small Chips and a Buddy Drink",
                Price = 79.90M,
                MenuId = kfcBoxMealsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "All Star Box Meal Buddy",
                Description = "Crunch Burger, 1 Piece of Original Recipe Chicken, 2 Zinger Wings, Small Chips & Buddy Drink",
                Price = 94.90M,
                MenuId = kfcBoxMealsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Wrapsta Box Meal",
                Description = "Wrapsta, 1 Piece of Original Recipe Chicken, Small Chips & Buddy Drink",
                Price = 84.90M,
                MenuId = kfcBoxMealsGuid

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
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "SW Bozza Crunch Burger Box Buddy",
                Description = "Enjoy a delicious Crunch Burger an orginal receipe chicken piece with small chips and a buddy no sugar drink",
                Price = 71.90M,
                MenuId = kfcStreetwiseGuid
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "SW Bozza Streetwise 5 Buddy",
                Description = "Get yourself a Streetwise 5, with 2 Buddy No Sugar",
                Price = 143.90M,
                MenuId = kfcStreetwiseGuid
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
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Large Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 0,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 26.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "1 Piece Chicken",
                Description = "1 Piece Chicken",
                Price = 26.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Large Mash & Gravy",
                Description = "A portion of creamy mash and our delicious gravy.",
                Price = 27.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Coleslaw",
                Description = "A portion of freshly prepared cabbage, onions and carrots in a delicious dressing",
                Price = 24.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Regular Mash & Gravy",
                Description = "A portion of creamy mash and our delicious gravy.",
                Price = 19.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Small Chips",
                Description = "A portion of chips, crispy on the outside, soft and fluffy on the inside.",
                Price = 16.90M,
                MenuId = kfcAddOnsGuid

            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = Guid.NewGuid(),
                Name = "Mini Loaf",
                Description = "Oven baked, fresh mini loaf",
                Price = 14.90M,
                MenuId = kfcAddOnsGuid

            });


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

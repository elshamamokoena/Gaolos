using Blazored.LocalStorage;
using Gaolos.Web.App.Auth;
using Gaolos.Web.App.Contracts;
using Gaolos.Web.App.Services;
using Gaolos.Web.App;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<CookieHandler>();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AuthenticationStateProvider, CookieAuthenticationStateProvider>();

builder.Services.AddTransient<CookieAuthenticationStateProvider>();

builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://localhost:7234/"))
    .AddHttpMessageHandler<CookieHandler>();

builder.Services.AddHttpClient(
    "Authentication",
    client => client.BaseAddress = new Uri("https://localhost:7234"))
    .AddHttpMessageHandler<CookieHandler>();

builder.Services.AddScoped<IRestaurantDataService, RestaurantDataService>();
builder.Services.AddScoped<ICategoryDataService, CategoryDataService>();
//builder.Services.AddScoped<IOrderDataService, OrderDataService>();
builder.Services.AddScoped<IMenuDataService, MenuDataService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();
builder.Services.AddScoped<IAccountDataService, AccountDataService>();
builder.Services.AddScoped<IShoppingBasketService, ShoppingBasketDataService>();
builder.Services.AddScoped<ApplicationState>();

await builder.Build().RunAsync();
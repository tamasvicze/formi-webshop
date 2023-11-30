global using FormiWebshop.Client.Services.ProductService;
global using FormiWebshop.Client.Services.CategoryService;
global using FormiWebshop.Shared;
global using System.Net.Http.Json;
global using FormiWebshop.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
global using FormiWebshop.Client.Services.OrderService;
global using FormiWebshop.Client.Services.CartService;
global using FormiWebshop.Client.Services.AddressService;
global using Microsoft.AspNetCore.Authorization;
global using FormiWebshop.Client.Services.ProductTypeService;
using Blazored.LocalStorage;
using FormiWebshop.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Localization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

var host = builder.Build();
await host.SetDefaultCulture(); // Retrieves local storage value and sets the thread's current culture.
await host.RunAsync();
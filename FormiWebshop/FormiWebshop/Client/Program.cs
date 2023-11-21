global using FormiWebshop.Client.Services.ProductService;
global using FormiWebshop.Client.Services.CategoryService;
global using FormiWebshop.Shared;
global using System.Net.Http.Json;
global using FormiWebshop.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
global using FormiWebshop.Client.Services.OrderService;
global using FormiWebshop.Client.Services.CartService;
global using FormiWebshop.Client.Services.AddressService;
using Blazored.LocalStorage;
using FormiWebshop.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
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
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();

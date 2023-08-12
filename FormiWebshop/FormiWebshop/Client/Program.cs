global using FormiWebshop.Client.Services.ProductService;
global using FormiWebshop.Client.Services.CategoryService;
global using FormiWebshop.Shared;
global using System.Net.Http.Json;
using Blazored.LocalStorage;
using FormiWebshop.Client;
using FormiWebshop.Client.Services.CartService;
using FormiWebshop.Client.Services.CategoryService;
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

await builder.Build().RunAsync();

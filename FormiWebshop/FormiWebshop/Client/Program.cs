global using FormiWebshop.Client.Services.ProductService;
global using FormiWebshop.Client.Services.CategoryService;
global using FormiWebshop.Shared;
global using System.Net.Http.Json;
using FormiWebshop.Client;
using FormiWebshop.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();

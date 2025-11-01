using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScuderiaCastellonApp; 
using MudBlazor.Services; 
using ScuderiaCastellonApp.Services; 

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 🛑 ESTE ES EL ÚNICO REGISTRO DE HttpClient NECESARIO Y CORRECTO
builder.Services.AddScoped(sp => new HttpClient()); 

builder.Services.AddMudServices(); 
builder.Services.AddScoped<ApiService>(); 

await builder.Build().RunAsync();
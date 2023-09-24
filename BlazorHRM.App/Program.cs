using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorHRM.App;
using BlazorHRM.App.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// //service for making requests back to the server of origin
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//using httpfactory instead, using Microsoft.Extensions.Http nuget
builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client =>
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();

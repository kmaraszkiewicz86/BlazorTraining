using BlazorDemo.UI.Client.HttpServices;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

string apiUrl = "https://localhost:5067/api";

builder.Services
    .AddRefitClient<ITodoApi>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(apiUrl);
    });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();

await builder.Build().RunAsync();

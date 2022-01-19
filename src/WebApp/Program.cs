using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp;
using MudBlazor.Services;
using Refit;
using WebApp.Core.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddRefitClient<IGithubRepository>().ConfigureHttpClient(x=> x.BaseAddress = new Uri("https://api.github.com"));
await builder.Build().RunAsync();

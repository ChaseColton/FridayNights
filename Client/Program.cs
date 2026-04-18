using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddHttpClient();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });




builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://localhost:5001/") } // <-- Server port
);

//builder.Services.AddScoped(sp =>
//    new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }
//);



// Use a named client to store default GitHub headers
//builder.Services.AddHttpClient("GitHubClient", client =>
//{
//    client.BaseAddress = new Uri("https://api.github.com/");
//    client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
//    client.DefaultRequestHeaders.Add("User-Agent", "BlazorApp-2026");
//});

await builder.Build().RunAsync();

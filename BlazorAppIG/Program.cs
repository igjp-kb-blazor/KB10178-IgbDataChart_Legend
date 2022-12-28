using BlazorAppIG;
using IgniteUI.Blazor.Controls;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddIgniteUIBlazor(
    typeof(IgbLegendModule),
    typeof(IgbDataChartCoreModule),
    typeof(IgbDataChartCategoryModule),
    typeof(IgbDataChartCategoryCoreModule),
    typeof(IgbDataChartInteractivityModule),
    typeof(IgbDataChartStackedModule),
    typeof(IgbStackedFragmentSeriesModule),
    typeof(IgbCalloutLayerModule)
);


await builder.Build().RunAsync();

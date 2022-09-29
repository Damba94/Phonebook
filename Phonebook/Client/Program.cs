using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Phonebook.Client;
using Phonebook.Client.Services.AddressService;
using Phonebook.Client.Services.PersonService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IAddressSrvice, AddressService>();
await builder.Build().RunAsync();

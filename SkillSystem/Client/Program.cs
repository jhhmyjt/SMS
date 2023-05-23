global using SkillSystem.Shared;
global using SkillSystem.Client.Services.AuthService;
global using Blazored.LocalStorage;
global using Microsoft.AspNetCore.Components.Authorization;
global using SkillSystem.Client.Services.TrainingService;
global using SkillSystem.Client.Services.SkillService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SkillSystem.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//添加本地存储服务
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//添加服务
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITrainingService, TrainingService>();
builder.Services.AddScoped<ISkillService,SkillService>();

//添加自定义认证状态提供器服务
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();

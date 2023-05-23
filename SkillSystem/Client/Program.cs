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

//��ӱ��ش洢����
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//��ӷ���
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITrainingService, TrainingService>();
builder.Services.AddScoped<ISkillService,SkillService>();

//����Զ�����֤״̬�ṩ������
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();

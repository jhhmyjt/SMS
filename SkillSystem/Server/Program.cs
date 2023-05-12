global using SkillSystem.Shared;
global using Microsoft.EntityFrameworkCore;
global using SkillSystem.Server.Services.AuthService;
global using SkillSystem.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//ע��DbContext
builder.Services.AddDbContext<DataContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//���swaggerUI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//��ӷ���
builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

//���swaggerUI
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseSwagger();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.sercive;
using EnterpriseCarDealership.service_repository_s.Service;
using EnterpriseCarDealership.service_repository_s.Service.cookies;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IBikeRepo,
BikeRepo>();
builder.Services.AddScoped<IBikeService,
BikeService>();

builder.Services.AddScoped<ICarRepo,
CarRepo>();
builder.Services.AddScoped<ICarService,
CarService>();

builder.Services.AddScoped<IBikeBookingService,
BikeBookingService>();
builder.Services.AddScoped<IBikeBookingRepo,
BikeBookingRepo>();

builder.Services.AddScoped<ICarBookingRepo,
CarBookingRepo>();
builder.Services.AddScoped<ICarBookingService,
CarBookingService>();

builder.Services.AddSingleton<IKundeRepo,
KundeRepo>();
builder.Services.AddSingleton<IKundeService,
KundeService>();

builder.Services.AddSingleton<IManagerRepo,
ManagerRepo>();
builder.Services.AddSingleton<IManagerService,
ManagerService>();

builder.Services.AddSingleton<IMedarbejderRepo,
MedarbejderRepo>();
builder.Services.AddSingleton<IMedarbejderService,
MedarbejderService>();

builder.Services.AddSingleton<IValidateUser, ValidateUser>();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();

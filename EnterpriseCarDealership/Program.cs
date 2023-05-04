using EnterpriseCarDealership.service_repository_s;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using EnterpriseCarDealership.service_repository_s.sercive;
using EnterpriseCarDealership.service_repository_s.Service;
using EnterpriseCarDealership.service_repository_s.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBikeRepo,
BikeRepo>();
builder.Services.AddSingleton<ICarRepo,
CarRepo>();

builder.Services.AddSingleton<IBikeBookingService,
BikeBookingService>();
builder.Services.AddSingleton<IBikeBookingRepo,
BikeBookingRepo>();

builder.Services.AddSingleton<ICarBookingRepo,
CarBookingRepo>();
builder.Services.AddSingleton<ICarBookingService,
CarBookingService>();

builder.Services.AddSingleton<IKundeRepo,
KundeRepo>();

builder.Services.AddSingleton<IManagerRepo,
ManagerRepo>();
builder.Services.AddSingleton<IManagerService,
ManagerService>();

builder.Services.AddSingleton<IMedarbejderRepo,
MedarbejderRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

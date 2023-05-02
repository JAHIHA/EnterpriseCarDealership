using DocumentFormat.OpenXml.Drawing;
using EnterpriseCarDealership.service_repository_s.repo;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IBikeRepo,
BikeRepo>();
builder.Services.AddSingleton<IBookingRepo,
BookingRepo>();
builder.Services.AddSingleton<IKundeRepo,
KundeRepo>();
builder.Services.AddSingleton<IManagerRepo,
ManagerRepo>();
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

using Community_Workshop_Booking.Data;
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Repositories;
using Community_Workshop_Booking.Repositories.Interfaces;
using Community_Workshop_Booking.Services;
using Community_Workshop_Booking.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//regjistrojme CommunityWorkshopContext ne Program
var connstring =  builder.Configuration.GetConnectionString("Connection");

builder.Services.AddDbContext<CommunityWorkshopContext>(options =>
    //e vendosim te sql serveri DBMS qe do perdorim 
    options.UseSqlServer(connstring)
    );

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn
    .RequireConfirmedAccount = false )
    .AddEntityFrameworkStores<CommunityWorkshopContext>()
    .AddDefaultTokenProviders();

//implemenotojme Services dhe Repositories
builder.Services.AddScoped<ICategoryRepository , CategoryRepository>();
builder.Services.AddScoped<IRegistrationRepository , RegistrationRepository>();
builder.Services.AddScoped<IVenueRepository , VenueRepository>();
builder.Services.AddScoped<IWorkshopRepository , WorkshopRepository>();

builder.Services.AddScoped<ICategoryService , CategoryService>();
builder.Services.AddScoped<IRegistrationService , RegistrationService>();
builder.Services.AddScoped<IVenueService , VenueService>();
builder.Services.AddScoped<IWorkshopService , WorkshopService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAntiforgery();
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();

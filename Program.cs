using Community_Workshop_Booking.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//regjistrojme CommunityWorkshopContext ne Program
var connstring =  builder.Configuration.GetConnectionString("Connection");

builder.Services.AddDbContext<CommunityWorkshopContext>(options =>
    //e vendosim te sql serveri DBMS qe do perdorim 
    options.UseSqlServer(connstring)
    );


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

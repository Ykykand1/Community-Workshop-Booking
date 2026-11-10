using Community_Workshop_Booking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Data;

public class CommunityWorkshopContext(DbContextOptions<CommunityWorkshopContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    //     builder.Entity<Workshop>().HasQueryFilter(w => !.w.IsDeleted)
    // }
    
    public DbSet<CategoryModel> Category { get; set; }
    
    public DbSet<RegistrationModel> Registration { get; set; }
    
    public DbSet<VenueModel>  Venue { get; set; }
    
    public DbSet<WorkshopModel> Workshop { get; set; }
}
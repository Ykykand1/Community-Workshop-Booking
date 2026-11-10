using Community_Workshop_Booking.Data;
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Repositories;

public class VenueRepository : IVenueRepository
{
    private readonly CommunityWorkshopContext _context;
    
    public VenueRepository(CommunityWorkshopContext context)
    {
        _context = context;
    }

    public async Task<List<VenueModel>> GetAll()
    {
        return await _context.Venue.ToListAsync();
    }
    
    public async Task<VenueModel?>  GetById(int id)
    {
        return await _context.Venue.FindAsync(id);
    }

    public async Task<VenueModel> AddVenue(VenueModel venue)
    {
        _context.Venue.Add(venue);
        await _context.SaveChangesAsync();
        
        return venue;
    }

    public async Task<VenueModel> UpdateVenue(VenueModel venue)
    {
        _context.Venue.Update(venue);
        await _context.SaveChangesAsync();
        return venue;
    }

    public async Task<VenueModel> DeleteVenue(int id)
    {
        var venue = await _context.Venue.FindAsync(id);

        if (venue == null)
        {
            return venue;
        }

        await _context.SaveChangesAsync();
        return venue;
    }
}
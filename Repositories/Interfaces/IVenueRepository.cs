using Community_Workshop_Booking.Models;

namespace Community_Workshop_Booking.Repositories.Interfaces;

public interface IVenueRepository
{
    Task<List<VenueModel>> GetAll();
    
    Task<VenueModel?> GetById(int id);
    
    Task<VenueModel> AddVenue(VenueModel venue);
    
    Task<VenueModel> UpdateVenue(VenueModel venue);
    
    Task<VenueModel> DeleteVenue(int id);
}
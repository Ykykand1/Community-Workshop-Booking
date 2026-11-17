using Community_Workshop_Booking.Models.VenueDTO;

namespace Community_Workshop_Booking.Services.Interfaces;

public interface IVenueService
{
    Task<List<ReadVenue>> GetAllVenues();
    
    Task<ReadVenue?> GetVenueById(int id);
    
    Task<CreateVenue> AddVenue(CreateVenue venue);
    
    Task<bool> UpdateVenue(int id ,UpdateVenue venue);
    
    Task<bool> DeleteVenue(int id);
}
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.VenueDTO;
using Community_Workshop_Booking.Repositories.Interfaces;
using Community_Workshop_Booking.Services.Interfaces;

namespace Community_Workshop_Booking.Services;

public class VenueService : IVenueService
{
    private readonly IVenueRepository _venueRepository;
    
    public VenueService(IVenueRepository repository)
    {
        _venueRepository = repository;
    }

    public async Task<List<ReadVenue>> GetAllVenues()
    {
        var venues = await _venueRepository.GetAll();
        var list = new List<ReadVenue>();

        foreach (var venue in venues)
        {
            list.Add(new ReadVenue
            {
                VenueId = venue.VenueId,
                Name = venue.Name,
                Address = venue.Address,
                MaxCapacity = venue.MaxCapacity,
            });
        }
        return list;
    }

    public async Task<ReadVenue?> GetVenueById(int id)
    {
        var venue = await _venueRepository.GetById(id);
        if (venue == null)
        {
            return null;
        }

        return new ReadVenue
        {
            VenueId = venue.VenueId,
            Name = venue.Name,
            Address = venue.Address,
            MaxCapacity = venue.MaxCapacity,
        };
    }

    public async Task<CreateVenue> AddVenue(CreateVenue venueDto)
    {
        var venue = new VenueModel
        {
          Name =  venueDto.Name,
          Address = venueDto.Address,
          MaxCapacity = venueDto.MaxCapacity,
        };

        await _venueRepository.AddVenue(venue);
        return venueDto;
    }

    public async Task<bool> UpdateVenue(int id, UpdateVenue venueDto)
    {
        var existingVenue = await _venueRepository.GetById(id);
        if (existingVenue == null)
        {
            return false;
        }

        existingVenue.Name = venueDto.Name;
        existingVenue.Address = venueDto.Address;
        existingVenue.MaxCapacity = venueDto.MaxCapacity;
        
        await _venueRepository.UpdateVenue(existingVenue);
        return true;
    }

    public async Task<bool> DeleteVenue(int id)
    {
        var venue = await _venueRepository.GetById(id);
        if (venue == null)
        {
            return false;
        }

        await _venueRepository.DeleteVenue(venue.VenueId);
        return true;
    }
}
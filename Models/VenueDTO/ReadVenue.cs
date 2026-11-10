namespace Community_Workshop_Booking.Models.VenueDTO;

public class ReadVenue
{
    public int VenueId { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
    
    public int MaxCapacity { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.VenueDTO;

public class CreateVenue
{
    [Required]
    public  string Name { get; set; }

    [Required] public string Address { get; set; }
    
    [Required] public int MaxCapacity{ get; set; }
 
}
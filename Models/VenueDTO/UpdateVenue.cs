using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.VenueDTO;

public class UpdateVenue
{
    
    [Required , StringLength(100)]public string Name { get; set; }
    
    [Required ,  StringLength(100)]public string Address { get; set; }
   
    [Required]  public int MaxCapacity { get; set; }
}
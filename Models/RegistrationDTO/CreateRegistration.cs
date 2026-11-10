using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.RegistrationDTO;

public class CreateRegistration
{
    [Required]
    public int WorkshopId { get; set; }
    
    [Required]
    public int UserId { get; set; }

    public RegistrationStatus RegistrationStatus { get; set; }
}
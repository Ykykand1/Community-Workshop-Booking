namespace Community_Workshop_Booking.Models.RegistrationDTO;

public class UpdateRegistration
{
    public int WorkshopId { get; set; }
    
    public int UserId { get; set; }
    
    public RegistrationStatus RegistrationStatus { get; set; }
}
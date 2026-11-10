namespace Community_Workshop_Booking.Models.RegistrationDTO;

public class ReadRegistration
{
    public int RegistrationId { get; set; }
    
    public int WorkshopId { get; set; }
    
    public int UserId { get; set; }
    
    public DateTime RegisteredAt { get; set; }
    
    public RegistrationStatus RegistrationStatus { get; set; }
}
namespace Community_Workshop_Booking.Models;
using System.ComponentModel.DataAnnotations;

public enum RegistrationStatus
{
    Active,
    Inactive
}

public class RegistrationModel
{
    [Key]
    public int RegistrationId { get; set; }
  
    public int WorkshopId { get; set; }
    
    public int UserId { get; set; }
    
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    
    public RegistrationStatus Status { get; set; }
    
    bool isDeleted  { get; set; } =  false;
}
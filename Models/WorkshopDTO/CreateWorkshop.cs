using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.WorkshopDTO;

public class CreateWorkshop
{
    [Required] public string Title {get; set;}
    
    [Required] public string Description {get; set;}
    
    [Required]public DateTime StartTime {get; set;}
    
    [Required]public DateTime EndTime {get; set;}
    
    public int Capacity {get; set;}
    
    [Required] public decimal Price{get; set;}
    
    public WorkshopStatus Status {get; set;}
    
    public int CategoryId {get; set;}
    
    public int VenueId {get; set;}
    
    public int OrganizerId {get; set;}
}
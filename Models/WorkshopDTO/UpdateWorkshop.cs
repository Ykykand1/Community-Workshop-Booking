using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.WorkshopDTO;

public class UpdateWorkshop
{
    [Required]public string Title {get; set;}
    
    [Required]public string Description {get; set;}
    
    [Required]public DateTime StartTime {get; set;}
    
    [Required]public DateTime EndTime {get; set;}
    
    public int Capacity {get; set;}
    
    public decimal Price{get; set;}
    
    public WorkshopStatus Status {get; set;}
}
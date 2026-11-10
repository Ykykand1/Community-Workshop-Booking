namespace Community_Workshop_Booking.Models.WorkshopDTO;

public class ReadWorkshop
{
    public string Title {get; set;}
    
    public string Description {get; set;}
    
    public DateTime StartTime {get; set;}
    
    public DateTime EndTime {get; set;}
    
    public int Capacity {get; set;}
    
    public decimal Price{get; set;}
    
    public WorkshopStatus Status {get; set;}
    
    public int CategoryId {get; set;}
    
    public int VenueId {get; set;}
    
    public int OrganizerId {get; set;}
}
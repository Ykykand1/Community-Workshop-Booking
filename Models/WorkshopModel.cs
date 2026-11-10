using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Models;
using System.ComponentModel.DataAnnotations;

public enum WorkshopStatus
{
    Unknown = 0,
    Draft = 1,
    Published = 2,
    Completed = 3,
    Cancelled = 4   
}

public class WorkshopModel
{
    [Key]
    public int WorkshopId { get; set; }
    
    [StringLength(70)]
    public string Title { get; set; }
    
    [StringLength(100)]
    public string Description { get; set; }
    
    public DateTime StartTime { get; set; }
        
    public DateTime EndTime { get; set; }
    
    public int Capacity { get; set; }
    
    [Required]
    [Precision(10 , 2)]
    public decimal Price { get; set; }
    
    public WorkshopStatus Status {get; set;}

    public int CategoryId { get; set; }
    
    public int  VenueId{get; set;}
    
    public int OrganizerId{get; set;}
    
    public bool isDeleted  { get; set; } =  false;
}
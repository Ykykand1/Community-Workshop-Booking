namespace Community_Workshop_Booking.Models;
using System.ComponentModel.DataAnnotations;

public class VenueModel
{
    [Key]
    public  int VenueId { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; }
    
    [StringLength(100)]
    public string Address { get; set; }
    
    public int MaxCapacity { get; set; }
  
    bool isDeleted  { get; set; } =  false;
}
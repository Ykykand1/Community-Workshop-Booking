using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.CategoryDTO;

public class ReadCategory
{
    public int CategoryId { get; set; }
    
    [Required] public string CategoryName { get; set; }
}
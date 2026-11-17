using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.CategoryDTO;

public class CreateCategory
{
    [Required]
    public string CategoryName { get; set; }
}
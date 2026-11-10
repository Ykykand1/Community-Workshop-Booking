using System.ComponentModel.DataAnnotations;

namespace Community_Workshop_Booking.Models.CategoryDTO;

public class CreateCategory
{
    [Required]
    string CategoryName { get; set; }
}
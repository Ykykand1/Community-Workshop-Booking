using System.ComponentModel.Design;

namespace Community_Workshop_Booking.Models;
using System.ComponentModel.DataAnnotations;

public class CategoryModel
{
    //tregojme EF qe kjo eshte PK per tabelen
    [Key]
    public int CategoryId { get; set; }
    
    [StringLength(100)]
    string CategoryName { get; set; }
    
    bool isDeleted  { get; set; } =  false;
    
}
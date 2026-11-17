using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.CategoryDTO;

namespace Community_Workshop_Booking.Services.Interfaces;

public interface ICategoryService
{
    Task<List<ReadCategory>> GetAllCategories();

    Task<ReadCategory?> GetCategoryById(int id);
    
    //Task<ReadCategory?> GetCategoryByName(string name);
    
    Task<CreateCategory> AddCategory(CreateCategory categoryDto);
    
    Task<bool>  UpdateCategory(int id, UpdateCategory categoryDto);
    
    Task<bool> DeleteCategory(int id);
}
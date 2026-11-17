using Community_Workshop_Booking.Models;

namespace Community_Workshop_Booking.Repositories.Interfaces;

public interface ICategoryRepository
{
    Task<List<CategoryModel>> GetAllCategories();
    
    Task<CategoryModel?> GetCategoryById(int id);
    
    Task<CategoryModel> AddCategory(CategoryModel category);
    
    Task<CategoryModel> UpdateCategory(CategoryModel category);
    
    Task<CategoryModel?> DeleteCategory(int id);
}
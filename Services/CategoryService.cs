using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.CategoryDTO;
using Community_Workshop_Booking.Repositories.Interfaces;
using Community_Workshop_Booking.Services.Interfaces;

namespace Community_Workshop_Booking.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    
    public CategoryService(ICategoryRepository categoryService)
    {
        _categoryRepository = categoryService;
    }

    public async Task<List<ReadCategory>> GetAllCategories()
    {
        var categories = await _categoryRepository.GetAllCategories();
        var list = new List<ReadCategory>();
        
        foreach (var category in categories)
        {
            list.Add(new ReadCategory
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            });
        }

        return list;
    }

    public async Task<ReadCategory?> GetCategoryById(int id)
    {
        var category = await _categoryRepository.GetCategoryById(id);
        if (category == null)
        {
            return null;
        }

        return new ReadCategory
        {
            CategoryId = category.CategoryId,
            CategoryName = category.CategoryName
        };
    }

    public async Task<CreateCategory> AddCategory(CreateCategory categoryDto)
    {
        var category = new CategoryModel
        {
            CategoryName = categoryDto.CategoryName
        };

        await _categoryRepository.AddCategory(category);
        return categoryDto;
    }

    public async Task<bool> UpdateCategory(int id ,UpdateCategory categoryDto)
    {
        var existingCategory = await _categoryRepository.GetCategoryById(id);
        if (existingCategory == null)
        {
            return false;
        }

        existingCategory.CategoryName = categoryDto.CategoryName;
        await _categoryRepository.UpdateCategory(existingCategory);
        return true;
    }

    public async Task<bool> DeleteCategory(int id)
    {
        var category = await _categoryRepository.GetCategoryById(id);
        if (category == null)
        {
            return false;
        }

        await _categoryRepository.DeleteCategory(category.CategoryId);
        return true;
    }
}
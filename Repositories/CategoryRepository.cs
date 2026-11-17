using Community_Workshop_Booking.Data;
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly CommunityWorkshopContext _context;

    public CategoryRepository(CommunityWorkshopContext context)
    {
        _context = context;
    }

    public async Task<List<CategoryModel>> GetAllCategories()
    {
        return await _context.Category.ToListAsync();
    }

    public async Task<CategoryModel?> GetCategoryById(int id)
    {
        return await _context.Category.FindAsync(id);
    }

    public async Task<CategoryModel> AddCategory(CategoryModel category)
    {
        await _context.Category.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<CategoryModel> UpdateCategory(CategoryModel category)
    {
        _context.Category.Update(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<CategoryModel?> DeleteCategory(int id)
    {
        var category = await _context.Category.FindAsync(id);
        if (category == null)
        {
            return null;
        }

        _context.Category.Remove(category);
        await  _context.SaveChangesAsync();
        return category;
    }

}
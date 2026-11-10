using Community_Workshop_Booking.Data;
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Repositories;

public class WorkshopRepository : IWorkshopRepository
{
    private readonly CommunityWorkshopContext _context;
    
    public WorkshopRepository(CommunityWorkshopContext context)
    {
        _context = context;
    }

    public async Task<List<WorkshopModel>> GetAll()
    {
        return await _context.Workshop.ToListAsync();
    }

    public async Task<WorkshopModel?> GetById(int id)
    {
        return await _context.Workshop.FindAsync(id);
    }

    public async Task<WorkshopModel> Add(WorkshopModel workshop)
    {
        //shton workshopin ne databaze
        _context.Workshop.Add(workshop);
        //ruan ndryshimet
        await _context.SaveChangesAsync();

        return workshop;
    }

    public async Task<WorkshopModel> Update(WorkshopModel workshop)
    {
        _context.Workshop.Update(workshop);
        await _context.SaveChangesAsync();
        return workshop;
    }

    public async Task<WorkshopModel> Delete(int id)
    {
        var workshop = await _context.Workshop.FindAsync(id);
        if (workshop == null)
        {
            return null;
        }

        _context.Workshop.Remove(workshop);
        await _context.SaveChangesAsync();
        return workshop;
    }
}   
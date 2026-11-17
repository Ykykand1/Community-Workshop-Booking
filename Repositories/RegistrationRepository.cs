using Community_Workshop_Booking.Data;
using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Community_Workshop_Booking.Repositories;

public class RegistrationRepository : IRegistrationRepository
{
    private readonly CommunityWorkshopContext _context;

    public RegistrationRepository(CommunityWorkshopContext context)
    {
        _context = context;
    }
    
    public async Task<List<RegistrationModel>> GetAllRegistrations()
    {
        return await _context.Registration.ToListAsync();
    }
    
    public async Task<RegistrationModel?> GetRegistrationById(int id)
    {
        return await _context.Registration.FindAsync(id);
    }

    public async Task<RegistrationModel> AddRegistration(RegistrationModel registration)
    {
        await _context.Registration.AddAsync(registration);
        await _context.SaveChangesAsync();
        return registration;
    }

    public async Task<RegistrationModel> UpdateRegistration(RegistrationModel registration)
    {
        _context.Registration.Update(registration);
        await _context.SaveChangesAsync();
        return registration;
    }

    public async Task<RegistrationModel?> DeleteRegistration(int id)
    {
        var registration = await _context.Registration.FindAsync(id);
        if (registration == null)
        {
            return null;
        }
        
        _context.Registration.Remove(registration);
        await _context.SaveChangesAsync();
        return registration;
    }
    
    
}
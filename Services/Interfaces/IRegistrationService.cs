using Community_Workshop_Booking.Models.RegistrationDTO;

namespace Community_Workshop_Booking.Services.Interfaces;

public interface IRegistrationService
{
    Task<List<ReadRegistration>> GetAllRegistrations();
    
    Task<ReadRegistration?> GetRegistrationById(int id);
    
    Task<CreateRegistration> CreateRegistration(CreateRegistration registration);
    
    Task<bool> UpdateRegistration(int id ,UpdateRegistration registration);
    
    Task<bool> DeleteRegistration(int id);
}
using Community_Workshop_Booking.Models;

namespace Community_Workshop_Booking.Repositories.Interfaces;

public interface IRegistrationRepository
{
    Task<List<RegistrationModel>> GetAllRegistrations();
    
    Task<RegistrationModel?> GetRegistrationById(int id);
    
    Task<RegistrationModel> AddRegistration(RegistrationModel registration);
    
    Task<RegistrationModel> UpdateRegistration(RegistrationModel registration);
    
    Task<RegistrationModel?> DeleteRegistration(int id);
}
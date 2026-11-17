using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.RegistrationDTO;
using Community_Workshop_Booking.Repositories.Interfaces;
using Community_Workshop_Booking.Services.Interfaces;

namespace Community_Workshop_Booking.Services;

public class RegistrationService : IRegistrationService
{
    private readonly IRegistrationRepository _registrationRepository;
    
    public  RegistrationService(IRegistrationRepository registrationRepository)
    {
        _registrationRepository = registrationRepository;
    }

    public async Task<List<ReadRegistration>> GetAllRegistrations()
    {
        var registrations = await _registrationRepository.GetAllRegistrations();
        var list = new List<ReadRegistration>();

        foreach (var registration in registrations)
        {
            list.Add(new ReadRegistration
            {
                RegistrationId = registration.RegistrationId,
                WorkshopId = registration.WorkshopId,
                UserId = registration.UserId,
                RegisteredAt = registration.RegisteredAt,
                Status = registration.Status
            });
        }
        return list;
    }

    public async Task<ReadRegistration?> GetRegistrationById(int id)
    {
        var registration = await _registrationRepository.GetRegistrationById(id);
        if (registration == null)
        {
            return null;
        }

        return new ReadRegistration
        {
            RegistrationId = registration.RegistrationId,
            WorkshopId = registration.WorkshopId,
            UserId = registration.UserId,
            RegisteredAt = registration.RegisteredAt,
            Status = registration.Status
        };
    }

    public async Task<CreateRegistration> CreateRegistration(CreateRegistration registrationDto)
    {
        var registration = new RegistrationModel
        {
           WorkshopId = registrationDto.WorkshopId,
           UserId = registrationDto.UserId,
           Status = registrationDto.Status
        };

        await _registrationRepository.AddRegistration(registration);
        return registrationDto;
    }

    public async Task<bool> UpdateRegistration(int id, UpdateRegistration registrationDto)
    {
        var existingRegistration = await _registrationRepository.GetRegistrationById(id);
        if (existingRegistration == null)
        {
            return false;
        }

        existingRegistration.WorkshopId = registrationDto.WorkshopId;
        existingRegistration.UserId = registrationDto.UserId;
        existingRegistration.Status = registrationDto.Status;
        
        await _registrationRepository.UpdateRegistration(existingRegistration);
        return true;
    }

    public async Task<bool> DeleteRegistration(int id)
    {
        var registration = await _registrationRepository.GetRegistrationById(id);
        if (registration == null)
        {
            return false;
        }

        await _registrationRepository.DeleteRegistration(registration.RegistrationId);
        return true;
    }
}
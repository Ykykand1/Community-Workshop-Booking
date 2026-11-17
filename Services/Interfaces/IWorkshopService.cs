using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.WorkshopDTO;

namespace Community_Workshop_Booking.Services.Interfaces;

public interface IWorkshopService
{
    Task<List<ReadWorkshop>> GetAllWorkshops();
    
    Task<ReadWorkshop?> GetWorkshopById(int id);
    
    Task<CreateWorkshop> AddWorkshop(CreateWorkshop workshop);
    
    Task<bool> UpdateWorkshop(int id ,UpdateWorkshop workshop);
    
    Task<bool> DeleteWorkshop(int id);
}
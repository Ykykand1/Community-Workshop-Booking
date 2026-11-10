using Community_Workshop_Booking.Models;

namespace Community_Workshop_Booking.Repositories.Interfaces;

public interface IWorkshopRepository
{
    //shfaq te gjitha workshopet
     Task<List<WorkshopModel>> GetAll();

    //shfaq workshopin sipas id
     Task<WorkshopModel?> GetById(int id);
    
    //shton nje workshop
    Task<WorkshopModel> Add(WorkshopModel workshop);
    
    //modifikon nje workshop ekzistues
    Task<WorkshopModel> Update(WorkshopModel workshop);
    
    //fshin nje repository
    Task<WorkshopModel> Delete(int id);
}
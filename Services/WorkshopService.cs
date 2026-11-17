using Community_Workshop_Booking.Models;
using Community_Workshop_Booking.Models.WorkshopDTO;
using Community_Workshop_Booking.Repositories.Interfaces;
using Community_Workshop_Booking.Services.Interfaces;
using Microsoft.Identity.Client;

namespace Community_Workshop_Booking.Services;

public class WorkshopService : IWorkshopService
{
    private readonly IWorkshopRepository _workshopRepository;

    public WorkshopService(
        IWorkshopRepository workshopRepository)
    {
        _workshopRepository = workshopRepository;
    }

    public async Task<List<ReadWorkshop>> GetAllWorkshops()
    {
        var workshops = await _workshopRepository.GetAll();
        var list = new List<ReadWorkshop>();

        foreach (var workshop in workshops)
        {
            list.Add(new ReadWorkshop
            {
                WorkshopId = workshop.WorkshopId,
                Title = workshop.Title,
                Description = workshop.Description,
                StartTime = workshop.StartTime,
                EndTime = workshop.EndTime,
                Capacity = workshop.Capacity,
                Price = workshop.Price,
                Status = workshop.Status,   
                CategoryId = workshop.CategoryId,
                VenueId = workshop.VenueId,
                OrganizerId = workshop.OrganizerId
            });
        }
        
        return list;
    }

    public async Task<ReadWorkshop?> GetWorkshopById(int id)
    {
        var workshop = await _workshopRepository.GetById(id);
        if (workshop == null)
        {
            return null;
        }

        return new ReadWorkshop
        {
            WorkshopId = workshop.WorkshopId,
            Title = workshop.Title,
            Description = workshop.Description,
            StartTime = workshop.StartTime,
            EndTime = workshop.EndTime,
            Capacity = workshop.Capacity,
            Price = workshop.Price,
            Status = workshop.Status,
            CategoryId = workshop.CategoryId,
            VenueId = workshop.VenueId,
            OrganizerId = workshop.OrganizerId
        };
    }

    public async Task<CreateWorkshop> AddWorkshop(CreateWorkshop workshopDto)
    {
        var workshop = new WorkshopModel
        {
            Title = workshopDto.Title,
            Description = workshopDto.Description,
            StartTime = workshopDto.StartTime,
            EndTime = workshopDto.EndTime,
            Capacity = workshopDto.Capacity,
            Price = workshopDto.Price,
            Status = workshopDto.Status,
            CategoryId = workshopDto.CategoryId,
            VenueId = workshopDto.VenueId,
            OrganizerId = workshopDto.OrganizerId
        };
        
        await _workshopRepository.Add(workshop);
        return workshopDto;
    }

    public async Task<bool> UpdateWorkshop(int id, UpdateWorkshop workshopDto)
    {
        var existingWorkshop = await _workshopRepository.GetById(id);
        if (existingWorkshop == null)
        {
            return false;
        }

        existingWorkshop.Title = workshopDto.Title;
        existingWorkshop.Description = workshopDto.Description;
        existingWorkshop.StartTime = workshopDto.StartTime;
        existingWorkshop.EndTime = workshopDto.EndTime;
        existingWorkshop.Capacity = workshopDto.Capacity;
        existingWorkshop.Price = workshopDto.Price;
        existingWorkshop.Status = workshopDto.Status;

        await _workshopRepository.Update(existingWorkshop);
        return true;
        
    }

    public async Task<bool> DeleteWorkshop(int id)
    {
        var workshop = await _workshopRepository.GetById(id);
        if (workshop == null)
        {
           return false;            
        }
        
        await _workshopRepository.Delete(workshop.WorkshopId);
        return true;
    }
}
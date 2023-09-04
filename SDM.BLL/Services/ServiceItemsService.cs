using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.DAL.Entities;
using SDM.DAL.Interfaces;

namespace SDM.BLL.Services;

public class ServiceItemsService : IServiceItemsService
{
	private readonly IServiceItemsRepository _repository;

    public ServiceItemsService(IServiceItemsRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceItemDTO>> GetAllServiceItems()
    {
        var serviceItems = _repository.GetAll();

        var mapper = new MapperConfiguration(cfg => 
            cfg.CreateMap<ServiceItem, ServiceItemDTO>()).CreateMapper();

        return mapper.Map<IEnumerable<ServiceItem>, List<ServiceItemDTO>>(serviceItems);
    }
}

using AutoMapper;
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

    public async Task DeleteServiceItem(Guid id)
    {
        await _repository.Delete(id);
    }

    public async Task<List<ServiceItemDTO>> GetAllServiceItems()
    {
        var serviceItems = _repository.GetAll();

        var mapper = new MapperConfiguration(cfg => 
            cfg.CreateMap<ServiceItem, ServiceItemDTO>()).CreateMapper();

        return mapper.Map<IEnumerable<ServiceItem>, List<ServiceItemDTO>>(serviceItems);
    }

    public async Task<ServiceItemDTO> GetServiceItemById(Guid id)
    {
        ServiceItem serviceItem = await _repository.GetById(id);

        var mapper = new MapperConfiguration(cfg =>
            cfg.CreateMap<ServiceItem, ServiceItemDTO>()).CreateMapper();

        return mapper.Map<ServiceItem, ServiceItemDTO>(serviceItem);
    }

    public async Task SaveServiceItem(ServiceItemDTO serviceItemDTO)
    {
        var mapper = new MapperConfiguration(cfg =>
            cfg.CreateMap<ServiceItemDTO, ServiceItem>()).CreateMapper();

        await _repository.Save(mapper.Map<ServiceItemDTO, ServiceItem>(serviceItemDTO));
    }
}

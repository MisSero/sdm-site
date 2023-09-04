using SDM.BLL.DTO;

namespace SDM.BLL.Interfaces;

public interface IServiceItemsService
{
	public Task<List<ServiceItemDTO>> GetAllServiceItems();
	public Task<ServiceItemDTO> GetServiceItemById(Guid id);
	public Task SaveServiceItem(ServiceItemDTO serviceItemDTO);
	public Task DeleteServiceItem(Guid id);
}

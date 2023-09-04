using SDM.BLL.DTO;

namespace SDM.BLL.Interfaces;

public interface IServiceItemsService
{
	public Task<List<ServiceItemDTO>> GetAllServiceItems();
}

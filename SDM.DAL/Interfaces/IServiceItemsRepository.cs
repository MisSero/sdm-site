using SDM.DAL.Entities;

namespace SDM.DAL.Interfaces;

public interface IServiceItemsRepository
{
	IQueryable<ServiceItem> GetAll();
	Task<ServiceItem> GetById(Guid id);
	Task Save(ServiceItem serviceItem);
	Task Delete(Guid id);
}

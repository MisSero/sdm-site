using SDM.DAL.Entities;

namespace SDM.DAL.Interfaces;

public interface IServiceItemsRepository
{
	IQueryable<ServiceItem> GetAll();
	Task<ServiceItem> GetById(Guid id);
	void Save(ServiceItem serviceItem);
	void Delete(Guid id);
}

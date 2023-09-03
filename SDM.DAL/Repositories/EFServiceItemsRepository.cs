using Microsoft.EntityFrameworkCore;
using SDM.DAL.EF;
using SDM.DAL.Entities;
using SDM.DAL.Interfaces;

namespace SDM.DAL.Repositories;

public class EFServiceItemsRepository : IServiceItemsRepository
{
	private readonly AppDbContext _db;

    public EFServiceItemsRepository(AppDbContext db)
    {
		_db = db;
    }

	public IQueryable<ServiceItem> GetAll()
	{
		return _db.ServiceItems;
	}

	public async Task<ServiceItem> GetById(Guid id)
	{
		return await _db.ServiceItems.FirstOrDefaultAsync(si => si.Id == id);
	}

	public async void Save(ServiceItem serviceItem)
	{
		if (serviceItem.Id == default)
			_db.Entry(serviceItem).State = EntityState.Added;
		else
			_db.Entry(serviceItem).State = EntityState.Modified;
		await _db.SaveChangesAsync();
	}

    public async void Delete(Guid id)
	{
		_db.ServiceItems.Remove(new ServiceItem { Id = id });
		await _db.SaveChangesAsync();
	}
}

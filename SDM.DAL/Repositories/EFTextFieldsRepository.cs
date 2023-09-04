using Microsoft.EntityFrameworkCore;
using SDM.DAL.EF;
using SDM.DAL.Entities;
using SDM.DAL.Interfaces;

namespace SDM.DAL.Repositories;

public class EFTextFieldsRepository : ITextFieldsRepository
{
	private readonly AppDbContext _db;

    public EFTextFieldsRepository(AppDbContext db)
    {
		_db = db;
    }

	public IQueryable<TextField> GetAll()
	{
		return _db.TextFields;
	}

	public async Task<TextField> GetById(Guid id)
	{
		return await _db.TextFields.FirstOrDefaultAsync(tf => tf.Id == id);
	}

	public async Task<TextField> GetByCodeWord(string codeWord)
	{
		return await _db.TextFields.FirstOrDefaultAsync(tf => tf.CodeWord == codeWord);
	}

	public async Task Save(TextField textField)
	{
		if (textField.Id == default)
			_db.Entry(textField).State = EntityState.Added;
		else
			_db.Entry(textField).State = EntityState.Modified;
		await _db.SaveChangesAsync();
	}

    public async void Delete(Guid id)
	{
		_db.TextFields.Remove(new TextField { Id = id });
		await _db.SaveChangesAsync();
	}
}

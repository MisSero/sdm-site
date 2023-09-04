using SDM.DAL.Entities;

namespace SDM.DAL.Interfaces;

public interface ITextFieldsRepository
{
	IQueryable<TextField> GetAll();
	Task<TextField> GetById(Guid id);
	Task<TextField> GetByCodeWord(string codeWord);
	Task Save(TextField textField);
	void Delete(Guid id);
}

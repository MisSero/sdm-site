using SDM.BLL.DTO;

namespace SDM.BLL.Interfaces;

public interface ITextFieldsService
{
	public Task<TextFieldDTO?> GetTextFildByCodeWord(string codeWord);
	public Task SaveTextFild(TextFieldDTO textFieldDTO);
}

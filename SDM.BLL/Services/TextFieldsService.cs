using AutoMapper;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.DAL.Entities;
using SDM.DAL.Interfaces;

namespace SDM.BLL.Services;

public class TextFieldsService : ITextFieldsService
{
	private readonly ITextFieldsRepository _repository;

    public TextFieldsService(ITextFieldsRepository repository)
    {
        _repository = repository;
    }

	public async Task<TextFieldDTO?> GetTextFildByCodeWord(string codeWord)
	{
		var textField = await _repository.GetByCodeWord(codeWord);
		if (textField != null)
		{
			var mapper = new MapperConfiguration(cfg =>
				cfg.CreateMap<TextField, TextFieldDTO>()).CreateMapper();

			return mapper.Map<TextField, TextFieldDTO>(textField);
		}

		return null;
	}

	public async Task SaveTextFild(TextFieldDTO textFieldDTO)
	{
		var mapper = new MapperConfiguration(cfg =>
				cfg.CreateMap<TextFieldDTO, TextField>()).CreateMapper();
		var textField = mapper.Map<TextFieldDTO, TextField>(textFieldDTO);

		await _repository.Save(textField);
	}

}

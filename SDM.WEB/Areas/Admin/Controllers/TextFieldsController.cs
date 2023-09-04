using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.WEB.Models;

namespace SDM.WEB.Areas.Admin.Controllers;

[Area("Admin")]
public class TextFieldsController : Controller
{
	private readonly ITextFieldsService _textFieldService;

    public TextFieldsController(ITextFieldsService textFieldsService)
    {
        _textFieldService = textFieldsService;
    }

    public async Task<IActionResult> Edit(string codeWord)
    {
        var textFieldsDTO = await _textFieldService.GetTextFildByCodeWord(codeWord);

        if (textFieldsDTO != null)
        {
		    var mapper = new MapperConfiguration(cfg =>
				    cfg.CreateMap<TextFieldDTO, TextFieldViewModel>()).CreateMapper();

            return View(mapper.Map<TextFieldDTO, TextFieldViewModel>(textFieldsDTO));
        }
        return BadRequest();
	}

    [HttpPost]
    public async Task<IActionResult> Edit(TextFieldViewModel model)
    {
        if (ModelState.IsValid)
        {
            var mapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<TextFieldViewModel, TextFieldDTO>()).CreateMapper();

            await _textFieldService.SaveTextFild(mapper.Map<TextFieldViewModel, TextFieldDTO>(model));
            return RedirectToAction("Index", "Home");
        }

        return View(model);
    }
}

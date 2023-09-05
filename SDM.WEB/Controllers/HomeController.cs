using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.WEB.Models;

namespace SDM.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITextFieldsService _textFieldsService;

        public HomeController(ITextFieldsService textFieldsService)
        {
            _textFieldsService = textFieldsService;
        }

        public async Task<ActionResult> Index()
        {
            var textField = await _textFieldsService.GetTextFildByCodeWord("PageIndex");
            var mapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<TextFieldDTO, TextFieldViewModel>()).CreateMapper();

            return View(mapper.Map<TextFieldDTO, TextFieldViewModel>(textField));
        }

		public async Task<ActionResult> Contacts()
		{
			var textField = await _textFieldsService.GetTextFildByCodeWord("PageContacts");
			var mapper = new MapperConfiguration(cfg =>
				cfg.CreateMap<TextFieldDTO, TextFieldViewModel>()).CreateMapper();

			return View(mapper.Map<TextFieldDTO, TextFieldViewModel>(textField));
		}
	}
}

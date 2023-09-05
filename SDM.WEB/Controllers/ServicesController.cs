using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.WEB.Models;

namespace SDM.WEB.Controllers;

public class ServicesController : Controller
{
    private readonly IServiceItemsService _itemsSerivce;
    private readonly ITextFieldsService _textFieldsService;

    public ServicesController(IServiceItemsService itemsService, ITextFieldsService textFieldsService)
    {
        _itemsSerivce = itemsService;
        _textFieldsService = textFieldsService;
    }

    public async Task<IActionResult> Index(Guid id)
    {
        var mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ServiceItemDTO, ServiceItemViewModel>();
            cfg.CreateMap<TextFieldDTO, TextFieldViewModel>();
        }).CreateMapper();

        if (id != default)
        {
            var serviceItemDTO = await _itemsSerivce.GetServiceItemById(id);
            return View("Show", mapper.Map<ServiceItemDTO, ServiceItemViewModel>(serviceItemDTO));
        }

        var TextFieldDTO = await _textFieldsService.GetTextFildByCodeWord("PageService");
        ViewBag.TextField = mapper.Map<TextFieldDTO, TextFieldViewModel>(TextFieldDTO);

        var serviceItemsDTO = await _itemsSerivce.GetAllServiceItems();
        return View(mapper.Map<List<ServiceItemDTO>, List<ServiceItemViewModel>>(serviceItemsDTO));
    }
}

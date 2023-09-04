using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.WEB.Models;

namespace SDM.WEB.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
	private readonly IServiceItemsService _itemsService;

    public HomeController(IServiceItemsService itemsService)
    {
        _itemsService = itemsService;
    }

    public async Task<IActionResult> Index()
	{
        var serviceItemsDTO = await _itemsService.GetAllServiceItems();

        var mapper = new MapperConfiguration(cfg =>
            cfg.CreateMap<ServiceItemDTO, ServiceItemViewModel>()).CreateMapper();
        var serviceItems = mapper.Map<IEnumerable<ServiceItemDTO>, 
            List<ServiceItemViewModel>>(serviceItemsDTO);

		return View(serviceItems);
	}
}

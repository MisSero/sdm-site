using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;

namespace SDM.WEB.Models.ViewComponents;

public class SidebarViewComponent : ViewComponent
{
    private readonly IServiceItemsService _itemsService;
    private readonly IMapper _mapper;

    public SidebarViewComponent(IServiceItemsService itemsService)
    {
        _itemsService = itemsService;
        _mapper = new MapperConfiguration(cfg =>
            cfg.CreateMap<ServiceItemDTO, ServiceItemViewModel>()).CreateMapper();
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var serviceItemsDTO = await _itemsService.GetAllServiceItems();

        return await Task.FromResult((IViewComponentResult)View("Default",
            _mapper.Map<List<ServiceItemDTO>, List<ServiceItemViewModel>>(serviceItemsDTO)));
    }
}

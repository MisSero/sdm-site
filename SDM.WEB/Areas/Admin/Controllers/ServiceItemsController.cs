using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SDM.BLL.DTO;
using SDM.BLL.Interfaces;
using SDM.WEB.Models;

namespace SDM.WEB.Areas.Admin.Controllers;

[Area("Admin")]
public class ServiceItemsController : Controller
{
    private readonly IServiceItemsService _serviceItemsService;
    private readonly IWebHostEnvironment _hostEnvironment;

    public ServiceItemsController(IServiceItemsService serviceItemsService,
        IWebHostEnvironment hostEnvironment)
    {
        _serviceItemsService = serviceItemsService;
         _hostEnvironment = hostEnvironment;
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        ServiceItemViewModel serviceItem;

        if (id == default)
            serviceItem = new ServiceItemViewModel();
        else
        {
            var serviceItemDTO = await _serviceItemsService.GetServiceItemById(id);
            var mapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<ServiceItemDTO, ServiceItemViewModel>()).CreateMapper();
            serviceItem = mapper.Map<ServiceItemDTO, ServiceItemViewModel>(serviceItemDTO);
        }

        return View(serviceItem);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(ServiceItemViewModel model, IFormFile titleImageFile)
    {
        if (ModelState.IsValid)
        {
            if (titleImageFile != null)
            {
                model.TitleImagePath = titleImageFile.FileName;
                using (var stream = new FileStream(Path.Combine(_hostEnvironment.WebRootPath, 
                    "images", titleImageFile.FileName), FileMode.Create))
                {
                    await titleImageFile.CopyToAsync(stream);
                }
            }

            var mapper = new MapperConfiguration(cfg =>
            cfg.CreateMap<ServiceItemViewModel, ServiceItemDTO>()).CreateMapper();
            await _serviceItemsService.SaveServiceItem(mapper.Map<ServiceItemViewModel, ServiceItemDTO>(model));

            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _serviceItemsService.DeleteServiceItem(id);
        return RedirectToAction("Index", "Home");
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SDM.WEB.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}

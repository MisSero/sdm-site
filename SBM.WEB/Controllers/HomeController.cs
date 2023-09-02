using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SBM.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

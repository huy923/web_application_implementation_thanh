using Microsoft.AspNetCore.Mvc;

namespace Harmic.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

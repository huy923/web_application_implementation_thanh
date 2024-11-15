using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Harmic.Controllers
{
    public class HomeController(ILogger<HomeController> logger, HarmicContext context) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly HarmicContext _context = context;

        public IActionResult Index()
        {
            ViewModel view = new ViewModel()
            {
                TbProductList = [.. _context.TbProducts],
                TbBlogList = [.. _context.TbBlogs],
                TbProductCategoryList = [.. _context.TbProductCategories]
            };
            return View(view);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

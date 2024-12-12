using Harmic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Harmic.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController(HarmicContext context) : Controller
    {
        private readonly HarmicContext _context = context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            var checkUser = _context.TbAccounts.Where(u => (u.Username == username) && (u.Password == password)).FirstOrDefault();
            if (checkUser != null)
            {

                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.UtcNow.AddYears(1)
                };
                Response.Cookies.Append("AdminLoggedIn", "true", cookieOptions);

                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            ViewBag.ErrorMessage = "User or password is wrong!";
            return View("Index");
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("AdminLoggedIn");
            return RedirectToAction("Index", "Login", new { area = "Admin" });
        }
    }
}

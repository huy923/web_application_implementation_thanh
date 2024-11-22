using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Harmic.Controllers
{
    public class BlogController( HarmicContext context) : Controller
    {
        private readonly HarmicContext _context = context;

        [Route("/Blog/{alias}-{id}.html")]
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null || _context.TbBlogs == null)
            {
                return NotFound();
            }
            var blogComments = _context.TbBlogComments.Where(m => m.BlogId == id);
            var blog = await _context.TbBlogs.FirstOrDefaultAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewModel view = new()
            {
                SelectedTblog = blog,
                TbBlogCommentList = [.. blogComments],
                TbBlogList = [.. _context.TbBlogs]
            };
            return View(view);
        }
    }
}

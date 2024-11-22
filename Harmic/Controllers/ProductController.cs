using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Harmic.Controllers
{
    public class ProductController(HarmicContext context) : Controller
    {
        private readonly HarmicContext _context = context;
        [Route("/product/{alias}-{id}.html")]
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null || _context.TbProducts == null)
            {
                return NotFound();
            }
            var product = await _context.TbProducts.Include(c => c.TbProductReviews).FirstOrDefaultAsync(m => m.ProductId == id);
            var ProductReview = _context.TbProductReviews.Where(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewModel view = new()
            {
                TbProductList = [.. _context.TbProducts],
                SelectedProduct = product,
                TbProductReviewList = [.. ProductReview]
            };
            return View(view);
        }
    }
}

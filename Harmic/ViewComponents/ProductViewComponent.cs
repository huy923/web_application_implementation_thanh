using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Harmic.ViewComponents
{
	public class ProductViewComponent : ViewComponent
	{
		private readonly HarmicContext _context;

		public ProductViewComponent(HarmicContext context)
		{
			_context = context;
		}

		//public async Task<IViewComponentResult> InvokeAsync()
		//{
		//	// Example logic for fetching products, replace as needed
		//	var products = await _context.TbProducts.Where(p => p.IsActive).ToList();
		//	return View(products);
		//}
	}
}

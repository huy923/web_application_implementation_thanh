using Harmic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Harmic.ViewComponents
{
    public class MenuTopViewComponent(HarmicContext context) : ViewComponent
    {
        private readonly HarmicContext _context = context;

        public async Task<IViewComponentResult> InvokeAsync(){
            var item = _context.TbMenus.Where(m => (bool)m.IsActive).OrderBy(m =>m.Position).ToList();
            return await Task.FromResult<IViewComponentResult>(View(item));
        }
    }
}

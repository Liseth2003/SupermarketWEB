using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Producto
{
    public class IndexModel : PageModel
    {

        private readonly SumpermarketContext _context;

        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }

        public IList<Product> Productos { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Productos != null)
            {
                Productos = await _context.Product.ToListAsync();
            }
        }
    }
}

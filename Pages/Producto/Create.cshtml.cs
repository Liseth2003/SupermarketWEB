using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;


namespace SupermarketWEB.Pages.Producto
{
    public class CreateModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public CreateModel(SumpermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Producto { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Productos == null || Producto == null)
            {
                return Page();
            }

            _context.Productos.Add(Producto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _contex;

        public IndexModel(SumpermarketContext contex)
        {
            _contex = contex;
        }

        public IList<Category> Categories { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_contex.Categories != null)
            {
                Categories = await _contex.Categories.ToArrayAsync();
            }
        }
    }
}

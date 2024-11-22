using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Platos
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantContext _context;

        public IndexModel(RestaurantContext context)
        {
            _context = context;
        }

        public IList<Plato> Platos { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Platos != null)
            {
                Platos = await _context.Platos.ToListAsync();
            }
        }
    }
}

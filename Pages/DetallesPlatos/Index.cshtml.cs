using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.DetallesPlatos
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantContext _context;

        public IndexModel(RestaurantContext context)
        {
            _context = context;
        }

        public IList<DetallesPlato> DetallesPlatos { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DetallesPlatos != null)
            {
                DetallesPlatos = await _context.DetallesPlatos.ToListAsync();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Proveedores
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantContext _context;

        public IndexModel(RestaurantContext context)
        {
            _context = context;
        }

        public IList<Proveedor> Proveedores { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Proveedores != null)
            {
                Proveedores = await _context.Proveedores.ToListAsync();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.DetallesPlatos
{
    public class DeleteModel : PageModel
    {
        private readonly RestaurantContext _context;

        public DeleteModel(RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetallesPlato DetallesPlatos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DetallesPlatos == null)
            {
                return NotFound();
            }

            var detallesPlatos = await _context.DetallesPlatos.FirstOrDefaultAsync(m => m.Id == id);

            if (detallesPlatos == null)
            {
                return NotFound();
            }
            else
            {
                DetallesPlatos = detallesPlatos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Platos == null)
            {
                return NotFound();
            }
            var detallesPlatos = await _context.DetallesPlatos.FindAsync(id);

            if (detallesPlatos != null)
            {
                DetallesPlatos = detallesPlatos;
                _context.DetallesPlatos.Remove(DetallesPlatos);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}

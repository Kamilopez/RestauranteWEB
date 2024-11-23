using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Proveedores
{
    public class DeleteModel : PageModel
    {
        private readonly RestaurantContext _context;

        public DeleteModel(RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proveedor Proveedores { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Proveedores == null)
            {
                return NotFound();
            }

            var proveedores = await _context.Proveedores.FirstOrDefaultAsync(m => m.Id == id);

            if (proveedores == null)
            {
                return NotFound();
            }
            else
            {
                Proveedores = proveedores;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Proveedores == null)
            {
                return NotFound();
            }
            var proveedores = await _context.Proveedores.FindAsync(id);

            if (proveedores != null)
            {
                Proveedores = proveedores;
                _context.Proveedores.Remove(Proveedores);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}

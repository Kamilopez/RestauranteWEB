using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.DetallesPlatos
{
    public class EditModel : PageModel
    {
        private readonly RestaurantContext _context;

        public EditModel(RestaurantContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(DetallesPlatos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(DetallesPlatos.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Index");
        }

        private bool CategoryExists(int id)
        {
            return (_context.DetallesPlatos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

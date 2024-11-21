using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Platos
{
    public class EditModel : PageModel
    {
        private readonly RestaurantContext _context;

        public EditModel(RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plato Platos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Platos == null)
            {
                return NotFound();
            }

            var Platos = await _context.Platos.FirstOrDefaultAsync(m => m.Id == id);

            if (Platos == null)
            {
                return NotFound();
            }
            else
            {
                Platos = Platos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(Platos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(Platos.Id))
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
            return (_context.Platos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

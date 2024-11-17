using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Ingrediente
{
    public class EditModel : PageModel
    {
        private readonly RestaurantContext _context;

        public EditModel(RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ingredientes Ingredientes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ingredientes == null)
            {
                return NotFound();
            }

            var ingredientes = await _context.Ingredientes.FirstOrDefaultAsync(m => m.Id == id);

            if (ingredientes == null)
            {
                return NotFound();
            }
            else
            {
                Ingredientes = ingredientes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(Ingredientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(Ingredientes.Id))
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
            return (_context.Ingredientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

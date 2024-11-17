using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Ingrediente
{
    public class DeleteModel : PageModel
    {
        private readonly RestaurantContext _context;

        public DeleteModel(RestaurantContext context)
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

            var Ingredientes = await _context.Ingredientes.FirstOrDefaultAsync(m => m.Id == id);

            if (Ingredientes == null)
            {
                return NotFound();
            }
            else
            {
                Ingredientes = Ingredientes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ingredientes == null)
            {
                return NotFound();
            }
            var Ingredientes = await _context.Ingredientes.FindAsync(id);

            if (Ingredientes != null)
            {
                Ingredientes = Ingredientes;
                _context.Ingredientes.Remove(Ingredientes);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}

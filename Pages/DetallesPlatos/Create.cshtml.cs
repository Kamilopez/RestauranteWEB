using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.DetallesPlatos
{
    public class CreateModel : PageModel
    {
        private readonly RestaurantContext _context;

        public CreateModel(RestaurantContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DetallesPlato DetallesPlatos { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.DetallesPlatos == null || DetallesPlatos == null)
            {
                return Page();
            }

            _context.DetallesPlatos.Add(DetallesPlatos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

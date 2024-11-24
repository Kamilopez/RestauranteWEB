using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Ingrediente
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
        public Ingredientes Ingrediente { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Ingredientes == null || Ingrediente == null)
            {
                //return Page();
            }

            _context.Ingredientes.Add(Ingrediente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

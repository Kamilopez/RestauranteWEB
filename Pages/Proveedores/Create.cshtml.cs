using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestauranteWEB.Data;

namespace RestauranteWEB.Pages.Proveedores
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
        public Plato Platos { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Platos == null || Platos == null)
            {
                return Page();
            }

            _context.Platos.Add(Platos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

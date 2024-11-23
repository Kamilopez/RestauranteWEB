using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

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
        public Proveedor Proveedores { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Proveedores == null || Proveedores == null)
            {
                return Page();
            }

            _context.Proveedores.Add(Proveedores);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

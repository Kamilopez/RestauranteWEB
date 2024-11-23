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
        public Proveedor Proveedor { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Proveedores == null || Proveedor == null)
            {
                return Page();
            }

            _context.Proveedores.Add(Proveedor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
    










    

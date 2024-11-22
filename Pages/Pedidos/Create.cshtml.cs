using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Pedidos
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
        public Pedido Pedidos { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Pedidos == null || Pedidos == null)
            {
                return Page();
            }

            _context.Pedidos.Add(Pedidos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

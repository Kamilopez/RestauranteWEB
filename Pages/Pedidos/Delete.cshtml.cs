using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Pedidos
{
    public class DeleteModel : PageModel
    {
        private readonly RestaurantContext _context;

        public DeleteModel(RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pedido Pedidos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pedidos == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos.FirstOrDefaultAsync(m => m.Id == id);

            if (pedidos == null)
            {
                return NotFound();
            }
            else
            {
                Pedidos = pedidos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pedidos == null)
            {
                return NotFound();
            }
            var Pedidos = await _context.Pedidos.FindAsync(id);

            if (Pedidos != null)
            {
                Pedidos = Pedidos;
                _context.Pedidos.Remove(Pedidos);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}

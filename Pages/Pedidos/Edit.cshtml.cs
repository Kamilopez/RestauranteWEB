using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Pedidos
{
    public class EditModel : PageModel
    {
		private readonly RestaurantContext _context;

		public EditModel(RestaurantContext context)
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

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_context.Attach(Pedidos).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CategoryExists(Pedidos.Id))
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
			return (_context.Pedidos?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}

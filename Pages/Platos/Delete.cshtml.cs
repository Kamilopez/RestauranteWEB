using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Platos
{
    public class DeleteModel : PageModel
    {
		private readonly RestaurantContext _context;

		public DeleteModel(RestaurantContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Plato Platos { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Platos == null)
			{
				return NotFound();
			}

			var Platos = await _context.Platos.FirstOrDefaultAsync(m => m.Id == id);

			if (Platos == null)
			{
				return NotFound();
			}
			else
			{
				Platos = Platos;
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null || _context.Platos == null)
			{
				return NotFound();
			}
			var Platos = await _context.Platos.FindAsync(id);

			if (Platos != null)
			{
				Platos = Platos;
				_context.Platos.Remove(Platos);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage("./Index");
		}
	}
}

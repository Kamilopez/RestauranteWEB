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
		public Ingredientes Ingredientes { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Ingredientes == null || Ingredientes == null)
			{
				return Page();
			}

			_context.Ingredientes.Add(Ingredientes);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}

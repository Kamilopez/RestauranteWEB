using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Data;
using RestauranteWEB.Models;

namespace RestauranteWEB.Pages.Ingrediente
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RestaurantContext _context;

        public IndexModel(RestaurantContext context)
        {
            _context = context;
        }

        public IList<Ingredientes> Ingredientes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ingredientes != null)
            {
                Ingredientes = await _context.Ingredientes.ToListAsync();
            }
        }
    }
}


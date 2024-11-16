using Microsoft.EntityFrameworkCore;
using RestauranteWEB.Models;

namespace RestauranteWEB.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ingredientes> Ingredientes { get; set; }
    }
}

namespace RestauranteWEB.Models
{
    public class DetallesPlato
    {
        public int Id { get; set; }
        public int IdPlato { get; set; }
        public Plato? Plato { get; set; } = default!;
        public int IdIngredientes { get; set; }
        public Ingredientes? Ingredientes { get; set; } = default!;
        public int Cantidad { get; set; }
    }
}

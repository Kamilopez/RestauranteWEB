namespace RestauranteWEB.Models
{
    public class DetallesPlato
    {
        public int Id { get; set; }
        public int PlatoId { get; set; }
        public Plato? Plato { get; set; } = default!;
        public int IngredientesId { get; set; }
        public Ingredientes? Ingredientes { get; set; } = default!;
        public int Cantidad { get; set; }
    }
}

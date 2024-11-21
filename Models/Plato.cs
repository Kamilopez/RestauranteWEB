using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteWEB.Models
{
    public class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioVenta { get; set; }
        public string Descripcion {  get; set; }
    }
}

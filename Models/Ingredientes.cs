using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteWEB.Models
{
    public class Ingredientes
    {
        public int Id { get; set; } //Será la llave primaria
        public string Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public int UnidadMedida { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal PrecioUnitario { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteWEB.Models
{
    public class Ingredientes
    {
        public int Id { get; set; } //Será la llave primaria
        public string NombreI { get; set; }
        public int CantidadDisponible { get; set; }
        public int UnidadMedida { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }
        public ICollection<DetallesPlato> DetallesPlatos { get; set; }

    }
}

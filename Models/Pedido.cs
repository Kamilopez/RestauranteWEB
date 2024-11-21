using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteWEB.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor? Proveedor { get; set; } = default!;
        public string FechaPedido { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Total {  get; set; }

    }
}

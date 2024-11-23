using System.ComponentModel.DataAnnotations;

namespace RestauranteWEB.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string Contacto { get; set; }
        public int Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Direccion { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
    }
}

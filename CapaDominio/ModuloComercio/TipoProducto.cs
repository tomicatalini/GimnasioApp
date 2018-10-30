using System.Collections.Generic;

namespace CapaDominio.ModuloComercio
{
    public class TipoProducto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual IList<Producto> Productos { get; set; }

        public TipoProducto() { }

        public TipoProducto(int id, string nombre)
        {

            this.Id = id;
            this.Nombre = nombre;

            this.Productos = new List<Producto>();
        }
    }
}

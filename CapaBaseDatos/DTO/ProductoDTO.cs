using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBaseDatos.DTO
{
    public class ProductoDTO
    {
        //Properties navigation
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Contenido { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string TipoProducto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloComercio
{
    class LineaMovimiento
    {

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }

        public virtual int MovimientoId { get; set; }
        public virtual Movimiento Movimiento { get; set; }

        public virtual int CodProducto { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

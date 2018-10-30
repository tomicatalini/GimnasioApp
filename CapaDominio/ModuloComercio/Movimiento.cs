using System;
using System.Collections.Generic;

namespace CapaDominio.ModuloComercio
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }

        public virtual IList<LineaMovimiento> LineaMovimientos { get; set; }
    }
}

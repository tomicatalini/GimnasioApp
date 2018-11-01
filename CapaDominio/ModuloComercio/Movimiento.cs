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

        public Movimiento(){}
        /// <summary>
        /// Constructor movimiento
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pFecha"></param>
        /// <param name="pTipoMovimiento"></param>
        public Movimiento(int pId, DateTime pFecha, TipoMovimiento pTipoMovimiento)
        {
            Id = pId;
            Fecha = DateTime.Today.Date;
            TipoMovimiento = pTipoMovimiento;

            this.LineaMovimientos = new List<LineaMovimiento>();
        }
    }
}

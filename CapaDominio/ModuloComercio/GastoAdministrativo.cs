using System;
using System.Collections.Generic;
using CapaDominio.ModuloComercio;

namespace CapaDominio.ModuloComercio
{
    public class GastoAdministrativo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public IList<LineaGastoAdministrativo> LineasGastosAdministrativos { get; set; }

        public virtual IList<LineaGastoAdministrativo> LineaGastosAdministrativos { get; set; }

        /// <summary>
        /// Constructor de GastoAdministrativo
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pCantidad"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pPrecioUnitario"></param>
        /// <param name="pFecha"></param>
        public GastoAdministrativo(int pId, DateTime pFecha)
        {
            this.Id = pId;
            this.Fecha = DateTime.Today.Date;

            this.LineasGastosAdministrativos = new List<LineaGastoAdministrativo>();
        }
    }
}

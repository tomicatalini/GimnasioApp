using System;

namespace CapaDominio.ModuloComercio
{
    public class GastoAdministrativo
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }

        public GastoAdministrativo(){}

        /// <summary>
        /// Constructor de GastoAdministrativo
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pCantidad"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pPrecioUnitario"></param>
        /// <param name="pFecha"></param>
        public GastoAdministrativo(int pId, int pCantidad, string pDescripcion, float pPrecioUnitario, DateTime pFecha)
        {
            this.Id = pId;
            this.Cantidad = pCantidad;
            this.Descripcion = pDescripcion;
            this.PrecioUnitario = pPrecioUnitario;
            this.Fecha = DateTime.Today.Date;
        }
    }
}

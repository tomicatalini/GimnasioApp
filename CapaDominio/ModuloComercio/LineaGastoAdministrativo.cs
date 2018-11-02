using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.ModuloComercio
{
    public class LineaGastoAdministrativo
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion {get; set;}
        public float precioUnitario { get; set; }

        public int IdGastoAdministrativo { get; set; }

        public LineaGastoAdministrativo(){}
        
        /// <summary>
        /// Constructor LineaGastoAdministrativo
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pCantidad"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pPrecioUnitario"></param>
        public LineaGastoAdministrativo(int pId, int pCantidad, string pDescripcion, float pPrecioUnitario, int pIdGastoAdministrativo)
        {
            Id = pId;
            Cantidad = pCantidad;
            Descripcion = pDescripcion;
            precioUnitario = pPrecioUnitario;
            IdGastoAdministrativo = pIdGastoAdministrativo;
        }

    }
}
